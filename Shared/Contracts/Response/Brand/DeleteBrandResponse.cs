using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Brand
{
    public class DeleteBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
