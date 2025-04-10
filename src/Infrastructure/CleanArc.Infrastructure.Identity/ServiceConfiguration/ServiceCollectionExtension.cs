using System.Security.Claims;
using System.Text;
using CleanArc.Application.Contracts;
using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.ApiResult;
using CleanArc.Infrastructure.Identity.Identity;
using CleanArc.Infrastructure.Identity.Identity.Dtos;
using CleanArc.Infrastructure.Identity.Identity.Extensions;
using CleanArc.Infrastructure.Identity.Identity.PermissionManager;
using CleanArc.Infrastructure.Identity.UserManager;
using CleanArc.Infrastructure.Persistence.Repositories;
using CleanArc.SharedKernel.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace CleanArc.Infrastructure.Identity.ServiceConfiguration;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterIdentityServices(this IServiceCollection services,IdentitySettings identitySettings)
    {




        services.AddScoped<IAuthorizationHandler, DynamicPermissionHandler>();
        services.AddScoped<IDynamicPermissionService, DynamicPermissionService>();
        




       
            //.AddUserValidator<AppUserValidator>().
            //AddRoleValidator<AppRoleValidator>().
            //.AddClaimsPrincipalFactory<AppUserClaimsPrincipleFactory>()
     


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
}