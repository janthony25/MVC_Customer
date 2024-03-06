using Microsoft.EntityFrameworkCore;
using MVC_Customer.Models;

namespace MVC_Customer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define foreign key relationship
            modelBuilder.Entity<Item>()
                .HasOne<Customer>(i => i.Customer)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CustomerId)
                .IsRequired();
        }
    }
}
