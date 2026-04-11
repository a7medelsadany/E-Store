namespace Shared.Contracts.Request.Product
{
    public class FetchProductRequest
    {
        public int PageNumber { get; set; }
        public int ProductsPerPage { get; set; }
        public string CategorySlug { get; set; }
        public string BrandSlug { get; set; }

    }
}
