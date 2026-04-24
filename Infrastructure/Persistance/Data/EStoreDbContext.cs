using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Domain.Entities.ProductModule;
using Domain.Entities.Cart;
using Domain.Entities.AddressModule;
using Domain.Entities.Customer;
using Domain.Entities.Order;

namespace Persistance.Data
{
    public class EStoreDbContext(DbContextOptions<EStoreDbContext> options):DbContext(options)
    {
        #region Dbsets
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        #endregion

        //for Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
