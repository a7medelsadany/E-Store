using Domain.Entities.Cart;

namespace Domain.Contrats
{
    public interface ICartRepository
    {
        Task<Cart?> GetCartByIdAsync(long Id);
        Task<IEnumerable<Cart>> GetAllAsync();
        void AddCart(Cart cart);
        void UpdateCart(Cart cart);
        void DeleteCart(Cart cart);

    }
}
