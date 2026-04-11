using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Brand
{
    public  class UpdateBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
