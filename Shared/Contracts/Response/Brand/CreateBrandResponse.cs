using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Brand
{
    public class CreateBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
