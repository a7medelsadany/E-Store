using Domain.Contrats;
using Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class OrderRepository(EStoreDbContext dbContext) : IOrderRepository
    {
        public async Task AddOrderAsync(Order order)
        {
            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(Order order)
        {
            dbContext.Orders.Remove(order);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await dbContext.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(p => p.Product)
                .ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(long id)
        {
            return await dbContext.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task UpdateOrderAsync(Order order)
        {
            dbContext.Orders.Update(order);
            await dbContext.SaveChangesAsync();
        }
    }
}
