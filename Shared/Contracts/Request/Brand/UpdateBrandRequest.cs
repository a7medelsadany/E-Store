using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Request.Brand
{
    public class UpdateBrandRequest
    {
        public int Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}
