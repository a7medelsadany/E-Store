namespace Domain.Entities.ProductModule
{
    public class Brand:BaseObject
    {
        public string Name { get; set; }=string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string MetaDescription { get; set; } = string.Empty;
        public string MetaKeywords { get; set; } = string.Empty;
        public BrandStatus randStatus { get; set; }

    }
}
