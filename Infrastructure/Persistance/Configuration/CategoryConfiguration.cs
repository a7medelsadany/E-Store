using Domain.Entities.ProductModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Laptops", Slug = "laptops", Description = "Laptop computers", MetaDescription = "Best laptops", MetaKeywords = "laptops,computers", CategoryStatus = CategoryStatus.Active, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
                new Category { Id = 2, Name = "Phones", Slug = "phones", Description = "Mobile phones", MetaDescription = "Best phones", MetaKeywords = "phones,mobile", CategoryStatus = CategoryStatus.Active, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
                new Category { Id = 3, Name = "Shoes", Slug = "shoes", Description = "Sports shoes", MetaDescription = "Best shoes", MetaKeywords = "shoes,sports", CategoryStatus = CategoryStatus.Active, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
                new Category { Id = 4, Name = "TVs", Slug = "tvs", Description = "Televisions", MetaDescription = "Best TVs", MetaKeywords = "tv,television,sony", CategoryStatus = CategoryStatus.Active, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false }
            );
        }
    }
}
