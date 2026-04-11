using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Domain.Entities.ProductModule;

namespace Persistance.Data
{
    public class EStoreDbContext(DbContextOptions<EStoreDbContext> options):DbContext(options)
    {
        #region Dbsets
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion

        //for Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
