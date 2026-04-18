using Domain.Contrats;
using Domain.Entities.Cart;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class CartRepository(EStoreDbContext _dbContext) : ICartRepository
    {
        public void AddCart(Cart cart)
        {
           _dbContext.Carts.Add(cart);
           _dbContext.SaveChangesAsync();
        }

        public void DeleteCart(Cart cart)
        {
            _dbContext.Carts.Remove(cart);
            _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            return await _dbContext.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .ToListAsync();
        }

        public async Task<Cart?> GetCartByIdAsync(long Id)
        {
            return await _dbContext.Carts
                .Include (c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(i=>i.Id==Id);
        }

        public void UpdateCart(Cart cart)
        {
            _dbContext.Carts.Update(cart);
            _dbContext.SaveChangesAsync();
        }
    }
}
