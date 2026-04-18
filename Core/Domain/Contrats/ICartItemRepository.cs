using Domain.Entities.Cart;

namespace Domain.Contrats
{
    public interface ICartItemRepository
    {
        Task<CartItem?> GetCartItemByIdAsync(long id);
        Task<IEnumerable<CartItem>> GetCartItemsByCartIdAsync(long cartId);
        Task AddCartItem(CartItem cartItem);
        Task UpdateCartItem(CartItem cartItem);
        Task DeleteCartItem(CartItem cartItem);
    }
}
