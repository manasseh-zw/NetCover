using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NetCover.Server.Data;


public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<RepositoryContext>();

        builder.UseNpgsql(options =>
        {
            configuration.GetConnectionString("PostgresCloud");
            options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        });

        return new RepositoryContext(builder.Options);
    }


}