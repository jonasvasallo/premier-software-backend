using Microsoft.EntityFrameworkCore;
using InventoryWebApp.Models;

namespace InventoryWebApp.Data;

public class InventoryDBContext : DbContext
{
    public InventoryDBContext(DbContextOptions<InventoryDBContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StockLog>()
            .HasOne(log => log.Item)
            .WithMany()
            .HasForeignKey(log => log.ItemId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>().HasData(
            new Item
            {
                Id = 1,
                Name = "Laptop",
                Description = "High performance laptop for developers",
                Stock = 10,
                Price = 28000.00m,
            },
            new Item
            {
                Id = 2,
                Name = "Smartphone",
                Description = "Latest generation flagship smartphone",
                Stock = 25,
                Price = 22000.00m,
            },
            new Item
            {
                Id = 3,
                Name = "Headphones",
                Description = "Noise-cancelling over-ear headphones",
                Stock = 50,
                Price = 899.99m,
            },
            new Item
            {
                Id = 4,
                Name = "Mechanical Keyboard",
                Description = "RGB backlit mechanical keyboard with blue switches",
                Stock = 15,
                Price = 1699.00m,
            },
            new Item
            {
                Id = 5,
                Name = "Gaming Mouse",
                Description = "High DPI wireless gaming mouse",
                Stock = 30,
                Price = 489.99m,
            }
        );
        
        modelBuilder.Entity<Sale>().HasData(
            new Sale
            {
                Id = 1,
                PurchaseDate = DateTime.UtcNow.AddDays(-10),
                UnitsSold = 2,
                ItemId = 1,
                SellingPrice = 28000.00m,
            },
            new Sale
            {
                Id = 2,
                PurchaseDate = DateTime.UtcNow.AddDays(-8),
                UnitsSold = 1,
                ItemId = 2,
                SellingPrice = 22000.00m,
            },
            new Sale
            {
                Id = 3,
                PurchaseDate = DateTime.UtcNow.AddDays(-5),
                UnitsSold = 3,
                ItemId = 3,
                SellingPrice = 899.99m,
            },
            new Sale
            {
                Id = 4,
                PurchaseDate = DateTime.UtcNow.AddDays(-3),
                UnitsSold = 1,
                ItemId = 4,
                SellingPrice = 1699.00m,
            },
            new Sale
            {
                Id = 5,
                PurchaseDate = DateTime.UtcNow.AddDays(-1),
                UnitsSold = 4,
                ItemId = 5,
                SellingPrice = 489.99m,
            }
        );
    }
    
    public DbSet<Item> Items { get; set; }
    public DbSet<Sale> Sales { get; set; }
    
    public DbSet<StockLog> StockLogs { get; set; }
}