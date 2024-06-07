using Microsoft.EntityFrameworkCore;

namespace NetCover.Server.Data;

public class RepositoryContext:DbContext
{
    
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CellTowerModel>().HasNoKey().HasIndex(ct => ct.MNC);

    }

    public DbSet<CellTowerModel> CellTowers { get; set; }
}