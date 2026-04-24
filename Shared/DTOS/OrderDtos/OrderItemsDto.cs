using Shared.DTOS.ProductDtos;

namespace Shared.DTOS.OrderDtos
{
    public class OrderItemsDto
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}
