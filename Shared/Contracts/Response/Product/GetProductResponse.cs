using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Product
{
    public class GetProductResponse: ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
