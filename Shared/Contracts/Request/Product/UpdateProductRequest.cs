using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Request.Product
{
    public  class UpdateProductRequest
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
    }
}
