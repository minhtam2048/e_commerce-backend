using Microsoft.EntityFrameworkCore;
using Shop_API.Models;

namespace Shop_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
            .HasMany(p => p.Orders)
            .WithOne(p => p.User)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderProduct>()
            .HasKey(op => new { op.OrderId, op.ProductId });

            builder.Entity<OrderProduct>()
            .HasOne(p => p.Product)
            .WithMany(o => o.OrderProducts)
            .HasForeignKey(op => op.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderProduct>()
            .HasOne(o => o.Order)
            .WithMany(p => p.OrderProducts)
            .HasForeignKey(op => op.OrderId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

