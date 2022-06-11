using InventoryDataAccess.Configuration;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace InventoryDataAccess;

public class InventoryContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<InOut>? InOuts { get; set; }
    public DbSet<Storage>? Storages { get; set; }
    public DbSet<WareHouse>? WareHouses { get; set; }

    public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new StorageConfiguration());
        modelBuilder.ApplyConfiguration(new InOutConfiguration());
    }
}
