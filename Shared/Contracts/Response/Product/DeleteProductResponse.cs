using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Product
{
    public class DeleteProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
