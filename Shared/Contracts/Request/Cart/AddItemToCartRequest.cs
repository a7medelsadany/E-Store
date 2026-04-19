using Shared.DTOS.CartDtos;

namespace Shared.Contracts.Request.Cart
{
    public class AddItemToCartRequest
    {
        public long CartId { get; set; }
        public CartItemDto cartItem { get; set; } 
        public long ProductId { get; set; }
    }
}
