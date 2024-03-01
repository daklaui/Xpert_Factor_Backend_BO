using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.TPostalCodes.Commands;
using CleanArc.Infrastructure.Persistence.Repositories;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infrastructure.Persistence.ServiceConfiguration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options
                .UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });
        
        services.AddScoped<ITPostalCodesRepository, TPostalCodesRepository>(); // Remplacez TPostalCodesRepository par votre implémentation concrète
        services.AddScoped<AddTPostalCodesCommandHandler>();
        services.AddScoped<UpdateTPostalCodesCommandHandler>();
        

        return services;
    }
    
   
        
   

}