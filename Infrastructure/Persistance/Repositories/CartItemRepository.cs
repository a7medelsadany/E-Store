using Domain.Contrats;
using Domain.Entities.Cart;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class CartItemRepository(EStoreDbContext _dbContext) : ICartItemRepository
    {
        public async Task AddCartItem(CartItem cartItem)
        {
            await _dbContext.AddAsync(cartItem);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCartItem(CartItem cartItem)
        {
            _dbContext.Remove(cartItem);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsByCartIdAsync(long cartId)
        {
            return await _dbContext.CartItems.Include(c => c.Product).Where(ci=>ci.CartId==cartId).ToListAsync();
        }

        public async Task<CartItem?> GetCartItemByIdAsync(long id)
        {
            return await _dbContext.CartItems.Include(c => c.Product).FirstOrDefaultAsync(ci => ci.Id == id);
        }

        public async Task UpdateCartItem(CartItem cartItem)
        {
            _dbContext.Update(cartItem);
            await _dbContext.SaveChangesAsync();
        }
    }
}
