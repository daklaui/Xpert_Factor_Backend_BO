﻿using CleanArc.Application.Common;
using Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Application.ServiceConfiguration;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediator(options =>
        {
            options.ServiceLifetime = ServiceLifetime.Scoped;
            options.Namespace = "CleanArc.Application.Mediator";
        });
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidateCommandBehavior<,>));
        services.AddAutoMapper(typeof(TPostalCodesProfile).Assembly);
        services.AddAutoMapper(typeof(TJobsProfile).Assembly);

        return services;
    }


   
}