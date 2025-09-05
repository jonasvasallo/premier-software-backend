using Microsoft.EntityFrameworkCore;
using InventoryWebApp.Models;

namespace InventoryWebApp.Data;

public class InventoryDBContext : DbContext
{
    public InventoryDBContext(DbContextOptions<InventoryDBContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>().HasData(
            new Item
            {
                Id = 1,
                Name = "CFMOTO 450SR",
                Description = "this is motorcycle by cfmoto",
                Quantity = 69,
                Price = 299000,
            },
            new Item
            {
                Id = 2,
                Name = "Ninja 400",
                Description = "this is motorcycle by Kawasaki",
                Quantity = 23,
                Price = 318000,
            }
        );
    }
    
    public DbSet<Item> Items { get; set; }
}