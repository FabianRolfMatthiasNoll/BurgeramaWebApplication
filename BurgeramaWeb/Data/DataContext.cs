using BurgeramaWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BurgeramaWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        //important to link the tables (Many to many Relationship) together based of their foreign Key
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });
            modelBuilder.Entity<OrderProduct>()
                .HasOne(o => o.Order)
                .WithMany(op => op.OrderProducts)
                .HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<OrderProduct>()
                .HasOne(o => o.Product)
                .WithMany(op => op.OrderProducts)
                .HasForeignKey(p => p.OrderId);
        }
    }
}
