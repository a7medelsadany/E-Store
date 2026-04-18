using Domain.Entities.ProductModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
          builder.HasData(
            // Apple Laptops
            new Product { Id = 1, Name = "MacBook Pro 14", Slug = "macbook-pro-14", Description = "Apple MacBook Pro 14 inch", MetaDescription = "MacBook Pro 14", MetaKeywords = "apple,macbook,laptop", SKU = "APL-MBP-14", Model = "MBP14", Price = 1999.99m, SalePrice = 1899.99m, OldPrice = 2099.99m, ImageUrl = "macbook-pro-14.jpg", QuantityInStock = 50, IsBestSeller = true, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 1, BrandId = 1, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
            new Product { Id = 2, Name = "MacBook Air M2", Slug = "macbook-air-m2", Description = "Apple MacBook Air M2", MetaDescription = "MacBook Air M2", MetaKeywords = "apple,macbook,laptop", SKU = "APL-MBA-M2", Model = "MBAM2", Price = 1299.99m, SalePrice = 1199.99m, OldPrice = 1399.99m, ImageUrl = "macbook-air-m2.jpg", QuantityInStock = 75, IsBestSeller = true, IsFeatured = false, ProductStatus = ProductStatus.Active, CategoryId = 1, BrandId = 1, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },

            // Samsung Laptops
            new Product { Id = 3, Name = "Samsung Galaxy Book3", Slug = "samsung-galaxy-book3", Description = "Samsung Galaxy Book3 Pro", MetaDescription = "Galaxy Book3", MetaKeywords = "samsung,laptop", SKU = "SAM-GB3-PRO", Model = "GB3PRO", Price = 1499.99m, SalePrice = 1399.99m, OldPrice = 1599.99m, ImageUrl = "galaxy-book3.jpg", QuantityInStock = 40, IsBestSeller = false, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 1, BrandId = 2, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },

            // Apple Phones
            new Product { Id = 4, Name = "iPhone 15 Pro", Slug = "iphone-15-pro", Description = "Apple iPhone 15 Pro", MetaDescription = "iPhone 15 Pro", MetaKeywords = "apple,iphone,phone", SKU = "APL-IP15-PRO", Model = "IP15PRO", Price = 999.99m, SalePrice = 949.99m, OldPrice = 1099.99m, ImageUrl = "iphone-15-pro.jpg", QuantityInStock = 100, IsBestSeller = true, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 2, BrandId = 1, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
            new Product { Id = 5, Name = "iPhone 15", Slug = "iphone-15", Description = "Apple iPhone 15", MetaDescription = "iPhone 15", MetaKeywords = "apple,iphone,phone", SKU = "APL-IP15", Model = "IP15", Price = 799.99m, SalePrice = 749.99m, OldPrice = 899.99m, ImageUrl = "iphone-15.jpg", QuantityInStock = 120, IsBestSeller = true, IsFeatured = false, ProductStatus = ProductStatus.Active, CategoryId = 2, BrandId = 1, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },

            // Samsung Phones
            new Product { Id = 6, Name = "Samsung Galaxy S24", Slug = "samsung-galaxy-s24", Description = "Samsung Galaxy S24 Ultra", MetaDescription = "Galaxy S24", MetaKeywords = "samsung,galaxy,phone", SKU = "SAM-GS24-ULT", Model = "GS24ULT", Price = 1199.99m, SalePrice = 1099.99m, OldPrice = 1299.99m, ImageUrl = "galaxy-s24.jpg", QuantityInStock = 80, IsBestSeller = true, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 2, BrandId = 2, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
            // Nike Shoes
            new Product { Id = 7, Name = "Nike Air Max 270", Slug = "nike-air-max-270", Description = "Nike Air Max 270", MetaDescription = "Air Max 270", MetaKeywords = "nike,shoes,airmax", SKU = "NK-AM-270", Model = "AM270", Price = 150.00m, SalePrice = 129.99m, OldPrice = 159.99m, ImageUrl = "air-max-270.jpg", QuantityInStock = 200, IsBestSeller = true, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 3, BrandId = 3, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },
            new Product { Id = 8, Name = "Nike Revolution 6", Slug = "nike-revolution-6", Description = "Nike Revolution 6", MetaDescription = "Revolution 6", MetaKeywords = "nike,shoes,running", SKU = "NK-REV-6", Model = "REV6", Price = 80.00m, SalePrice = 69.99m, OldPrice = 89.99m, ImageUrl = "revolution-6.jpg", QuantityInStock = 150, IsBestSeller = false, IsFeatured = false, ProductStatus = ProductStatus.Active, CategoryId = 3, BrandId = 3, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },

            // Adidas Shoes
            new Product { Id = 9, Name = "Adidas Ultraboost 23", Slug = "adidas-ultraboost-23", Description = "Adidas Ultraboost 23", MetaDescription = "Ultraboost 23", MetaKeywords = "adidas,shoes,ultraboost", SKU = "AD-UB-23", Model = "UB23", Price = 190.00m, SalePrice = 169.99m, OldPrice = 199.99m, ImageUrl = "ultraboost-23.jpg", QuantityInStock = 100, IsBestSeller = true, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 3, BrandId = 4, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false },

            // Sony TVs
            new Product { Id = 10, Name = "Sony BRAVIA XR 55", Slug = "sony-bravia-xr-55", Description = "Sony BRAVIA XR 55 inch 4K", MetaDescription = "BRAVIA XR 55", MetaKeywords = "sony,tv,bravia,4k", SKU = "SNY-BRV-55", Model = "BRV55XR", Price = 1299.99m, SalePrice = 1199.99m, OldPrice = 1399.99m, ImageUrl = "bravia-xr-55.jpg", QuantityInStock = 30, IsBestSeller = false, IsFeatured = true, ProductStatus = ProductStatus.Active, CategoryId = 4, BrandId = 5, CreateDate = DateTimeOffset.UtcNow, ModifiedDate = DateTimeOffset.UtcNow, IsDeleted = false }
          );
        }
    }
}
