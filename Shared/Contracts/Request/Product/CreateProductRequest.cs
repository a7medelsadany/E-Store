using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Request.Product
{
    public class CreateProductRequest
    {
        public ProductDto Product { get; set; }
    }
}
