using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Product
{
    public  class UpdateProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
