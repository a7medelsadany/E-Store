using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Brand
{
    public class FetchBrandResponse : ResponseBase
    {
        public int BrandsPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<BrandDto> Brands { get; set; }
    }
}
