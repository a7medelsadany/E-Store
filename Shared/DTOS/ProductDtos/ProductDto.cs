using Domain.Entities.ProductModule;

namespace Shared.DTOS.ProductDtos
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string MetaDescription { get; set; } = string.Empty;
        public string MetaKeywords { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public decimal OldPrice { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public long CatagoryId { get; set; }
        public Category Category { get; set; }
        public long BrandId { get; set; }
        public Brand Brand { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
