using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;

namespace TarifDostuApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<RepositoryContext>(options => 
            options.UseNpgsql(configuration
                .GetConnectionString("postgreSQLConnection")));

        public static void ConfigureLoggerService(this IServiceCollection services) => services.AddSingleton<ILoggerService, LoggerManager>();

        // Repositories Configuration - Repository Ayarları
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IIngredientRepository, IngredientRepository>();
        }

        // Services Configuration - Services Ayarları

        public static void ConfigureServicesManager(this IServiceCollection services) => services.AddScoped<IServiceManager, ServiceManager>();

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IIngredientService, IngredientManager>();

        }


    }
}
