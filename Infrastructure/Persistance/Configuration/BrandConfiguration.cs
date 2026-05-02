using Domain.Entities.ProductModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        private static readonly DateTimeOffset SeedDate =
           new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, Name = "Apple", Slug = "apple", Description = "Apple Inc.", MetaDescription = "Apple products", MetaKeywords = "apple,mac,iphone", randStatus = BrandStatus.Active, CreateDate = SeedDate, ModifiedDate = SeedDate, IsDeleted = false },
                new Brand { Id = 2, Name = "Samsung", Slug = "samsung", Description = "Samsung Electronics", MetaDescription = "Samsung products", MetaKeywords = "samsung,galaxy", randStatus = BrandStatus.Active, CreateDate = SeedDate, ModifiedDate = SeedDate, IsDeleted = false },
                new Brand { Id = 3, Name = "Nike", Slug = "nike", Description = "Nike Inc.", MetaDescription = "Nike products", MetaKeywords = "nike,shoes,sports", randStatus = BrandStatus.Active, CreateDate = SeedDate, ModifiedDate = SeedDate, IsDeleted = false },
                new Brand { Id = 4, Name = "Adidas", Slug = "adidas", Description = "Adidas AG", MetaDescription = "Adidas products", MetaKeywords = "adidas,shoes,sports", randStatus = BrandStatus.Active, CreateDate = SeedDate, ModifiedDate = SeedDate, IsDeleted = false },
                new Brand { Id = 5, Name = "Sony", Slug = "sony", Description = "Sony Corporation", MetaDescription = "Sony products", MetaKeywords = "sony,electronics", randStatus = BrandStatus.Active, CreateDate = SeedDate, ModifiedDate = SeedDate, IsDeleted = false }
            );
        }
    }
}
