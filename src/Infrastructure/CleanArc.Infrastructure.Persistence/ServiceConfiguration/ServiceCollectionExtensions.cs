using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;
using CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;
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
        services.AddScoped<IFinancementRepository, FinancementRepository>();
        services.AddScoped<ValidateFinanceCommandHandler>();
        services.AddScoped<RejectFinanceCommandHandler>();

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options
                .UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });

        return services;
    }
}