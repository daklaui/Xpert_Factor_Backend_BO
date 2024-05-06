﻿using System.Security.Claims;
using System.Text;
using CleanArc.Application.Contracts;
using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Models.ApiResult;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.User;
using CleanArc.Infrastructure.Identity.Identity;
using CleanArc.Infrastructure.Identity.Identity.Dtos;
using CleanArc.Infrastructure.Identity.Identity.Extensions;
using CleanArc.Infrastructure.Identity.Identity.Manager;
using CleanArc.Infrastructure.Identity.Identity.PermissionManager;
using CleanArc.Infrastructure.Identity.Identity.SeedDatabaseService;
using CleanArc.Infrastructure.Identity.Identity.Store;
using CleanArc.Infrastructure.Identity.Identity.validator;
using CleanArc.Infrastructure.Identity.Jwt;
using CleanArc.Infrastructure.Identity.UserManager;
using CleanArc.Infrastructure.Persistence;
using CleanArc.SharedKernel.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace CleanArc.Infrastructure.Identity.ServiceConfiguration;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterIdentityServices(this IServiceCollection services,IdentitySettings identitySettings)
    {
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IAppUserManager, AppUserManagerImplementation>();
        services.AddScoped<ISeedDataBase, SeedDataBase>();

        services.AddScoped<IUserValidator<User>, AppUserValidator>();
        services.AddScoped<UserValidator<User>, AppUserValidator>();

        services.AddScoped<IUserClaimsPrincipalFactory<User>, AppUserClaimsPrincipleFactory>();

        services.AddScoped<IRoleValidator<Role>, AppRoleValidator>();
        services.AddScoped<RoleValidator<Role>, AppRoleValidator>();

        services.AddScoped<IAuthorizationHandler, DynamicPermissionHandler>();
        services.AddScoped<IDynamicPermissionService, DynamicPermissionService>();
        services.AddScoped<IRoleStore<Role>, RoleStore>();
        services.AddScoped<IUserStore<User>, AppUserStore>();
        services.AddScoped<IRoleManagerService, RoleManagerService>();


        services.AddIdentity<User, Role>(options =>
            {
                options.Stores.ProtectPersonalData = false;

                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireUppercase = false;

                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = true;

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = false;
                options.User.RequireUniqueEmail = false;

                //options.Stores.ProtectPersonalData = true;


            }).AddUserStore<AppUserStore>()
            .AddRoleStore<RoleStore>().
            //.AddUserValidator<AppUserValidator>().
            //AddRoleValidator<AppRoleValidator>().
            AddUserManager<AppUserManager>().
            AddRoleManager<AppRoleManager>().
            AddErrorDescriber<AppErrorDescriber>()
            //.AddClaimsPrincipalFactory<AppUserClaimsPrincipleFactory>()
            .AddDefaultTokenProviders().
            AddSignInManager<AppSignInManager>()
            .AddDefaultTokenProviders()
            .AddPasswordlessLoginTotpTokenProvider();


        //For [ProtectPersonalData] Attribute In Identity

        //services.AddScoped<ILookupProtectorKeyRing, KeyRing>();

        //services.AddScoped<ILookupProtector, LookupProtector>();

        //services.AddScoped<IPersonalDataProtector, PersonalDataProtector>();

        services.AddAuthorization(options =>
        {
            options.AddPolicy(ConstantPolicies.DynamicPermission, policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.Requirements.Add(new DynamicPermissionRequirement());
            });
        });

        services.AddAuthentication( options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                
        }).AddJwtBearer(options =>
        {
            var secretkey = Encoding.UTF8.GetBytes(identitySettings.SecretKey);
            var encryptionkey = Encoding.UTF8.GetBytes(identitySettings.Encryptkey);

            var validationParameters = new TokenValidationParameters
            {
                ClockSkew = TimeSpan.Zero, // default: 5 min
                RequireSignedTokens = true,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretkey),

                RequireExpirationTime = true,
                ValidateLifetime = true,

                ValidateAudience = true, //default : false
                ValidAudience = identitySettings.Audience,

                ValidateIssuer = true, //default : false
                ValidIssuer = identitySettings.Issuer,

                TokenDecryptionKey = new SymmetricSecurityKey(encryptionkey),

            };

            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = validationParameters;
            options.Events = new JwtBearerEvents
            {
                OnAuthenticationFailed = context =>
                {
                    //var logger = context.HttpContext.RequestServices.GetRequiredService<ILoggerFactory>().CreateLogger(nameof(JwtBearerEvents));
                    //logger.LogError("Authentication failed.", context.Exception);

                    return Task.CompletedTask;
                },
                OnTokenValidated = async context =>
                {
                    var signInManager = context.HttpContext.RequestServices.GetRequiredService<AppSignInManager>();

                    var claimsIdentity = context.Principal.Identity as ClaimsIdentity;
                    if (claimsIdentity.Claims?.Any() != true)
                        context.Fail("This token has no claims.");

                    var securityStamp =
                        claimsIdentity.FindFirstValue(new ClaimsIdentityOptions().SecurityStampClaimType);
                    if (!securityStamp.HasValue())
                        context.Fail("This token has no secuirty stamp");

                    //Find user and token from database and perform your custom validation
                    var userId = claimsIdentity.GetUserId<int>();
                    // var user = await userRepository.GetByIdAsync(context.HttpContext.RequestAborted, userId);

                    //if (user.SecurityStamp != Guid.Parse(securityStamp))
                    //    context.Fail("Token secuirty stamp is not valid.");

                    var validatedUser = await signInManager.ValidateSecurityStampAsync(context.Principal);
                    if (validatedUser == null)
                        context.Fail("Token secuirty stamp is not valid.");

                },
                OnChallenge = async context =>
                {
                    //var logger = context.HttpContext.RequestServices.GetRequiredService<ILoggerFactory>().CreateLogger(nameof(JwtBearerEvents));
                    //logger.LogError("OnChallenge error", context.Error, context.ErrorDescription);
                    if (context.AuthenticateFailure is SecurityTokenExpiredException)
                    {
                        context.HandleResponse();

                        var response = new ApiResult(false,
                            ApiResultStatusCode.UnAuthorized, "Token is expired. refresh your token");
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        await context.Response.WriteAsJsonAsync(response);
                    }

                    else if (context.AuthenticateFailure != null)
                    {
                        context.HandleResponse();

                        var response = new ApiResult(false,
                            ApiResultStatusCode.UnAuthorized, "Token is Not Valid");
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        await context.Response.WriteAsJsonAsync(response);

                    }

                    else
                    {
                        context.HandleResponse();

                        context.Response.StatusCode = (int)StatusCodes.Status401Unauthorized;
                        await context.Response.WriteAsJsonAsync(new ApiResult(false, ApiResultStatusCode.UnAuthorized, "Invalid access token. Please login"));
                    }

                },
                OnForbidden =async context =>
                {
                    context.Response.StatusCode = (int)StatusCodes.Status403Forbidden;
                   await context.Response.WriteAsJsonAsync(new ApiResult(false,
                        ApiResultStatusCode.Forbidden, ApiResultStatusCode.Forbidden.ToDisplay()));
                }
            };
        });

        return services;
    }
    
   /* public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddIdentity<TS_USER, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                // Autres configurations selon vos besoins
            })
            .AddEntityFrameworkStores<ApplicationDbContext>() // Assurez-vous d'avoir un DbContext configuré
            .AddDefaultTokenProviders();

        // Configuration JWT
        var jwtSettings = configuration.GetSection("JwtSettings");
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = jwtSettings["validAudience"],
                    ValidIssuer = jwtSettings["validIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["securityKey"]))
                };
            });
        
        

        return services;
    }*/
   
   /*public static IServiceCollection RegisterIdentityServices(this IServiceCollection services, IdentitySettings identitySettings)
{
    // Enregistrement des services nécessaires
    services.AddScoped<IJwtService, JwtService>();
    services.AddScoped<IAppUserManager, AppUserManagerImplementation>();
    services.AddScoped<ISeedDataBase, SeedDataBase>();

    // Configuration spécifique pour utiliser vos types d'entités TS_USER et Role
    services.AddIdentity<User, Role>(options =>
    {
        // Configuration des options d'identité selon vos besoins
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireUppercase = false;


        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.AllowedForNewUsers = false;
        options.User.RequireUniqueEmail = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>() 
    .AddDefaultTokenProviders();

    // Configuration de l'autorisation dynamique
    services.AddScoped<IAuthorizationHandler, DynamicPermissionHandler>();
    services.AddScoped<IDynamicPermissionService, DynamicPermissionService>();

    // Configuration de l'authentification JWT
    services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        var secretKey = Encoding.UTF8.GetBytes(identitySettings.SecretKey);
        var encryptionKey = Encoding.UTF8.GetBytes(identitySettings.Encryptkey);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ClockSkew = TimeSpan.Zero,
            RequireSignedTokens = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secretKey),
            RequireExpirationTime = true,
            ValidateLifetime = true,
            ValidateAudience = true,
            ValidAudience = identitySettings.Audience,
            ValidateIssuer = true,
            ValidIssuer = identitySettings.Issuer,
            TokenDecryptionKey = new SymmetricSecurityKey(encryptionKey),
        };

        // Configurez ici les événements JWTBearer si nécessaire
    });

    // Configuration des politiques d'autorisation
    services.AddAuthorization(options =>
    {
        options.AddPolicy(ConstantPolicies.DynamicPermission, policy =>
        {
            policy.RequireAuthenticatedUser();
            policy.Requirements.Add(new DynamicPermissionRequirement());
        });
    });

    return services;
}*/
}