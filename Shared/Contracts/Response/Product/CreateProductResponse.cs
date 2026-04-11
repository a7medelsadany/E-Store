using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Product
{
    public class CreateProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
