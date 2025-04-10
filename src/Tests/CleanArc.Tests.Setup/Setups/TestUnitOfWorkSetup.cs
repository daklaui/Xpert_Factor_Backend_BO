using CleanArc.Application.Contracts.Persistence;
using CleanArc.Infrastructure.Persistence;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace CleanArc.Tests.Setup.Setups;



public abstract class TestUnitOfWorkSetup
{
    protected IUnitOfWork TestUnitOfWork { get; private set; }
    protected ApplicationDbContext TestDbContext { get; private set; }

    protected TestUnitOfWorkSetup()
    {
        var serviceCollection = new ServiceCollection();

     
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.Test.json")
            .Build();

        
        var connectionString = configuration.GetConnectionString("SqlServer");

        serviceCollection.AddLogging();

        serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        var serviceProvider = serviceCollection.BuildServiceProvider();
        TestDbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
        TestDbContext.Database.OpenConnection();
        TestDbContext.Database.EnsureCreated();

        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
       
        serviceProvider = serviceCollection.BuildServiceProvider();
        TestUnitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
    }
}


