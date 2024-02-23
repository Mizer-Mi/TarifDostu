using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repositories.EFCore;

namespace TarifDostuApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // DbContextOptionsBuilder
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseNpgsql(configuration.GetConnectionString("postgreSQLConnection"), prj => prj.MigrationsAssembly("TarifDostuApi"));

            return new RepositoryContext(builder.Options);
                

        }
    }
}
