using Domain.Contrats;
using Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class OrderItemRepository(EStoreDbContext dbContext) : IOrderItemRepository
    {
        public async Task AddOrderItemAsync(OrderItem item)
        {
            await dbContext.OrderItems.AddAsync(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderItemAsync(OrderItem item)
        {
            dbContext.OrderItems.Remove(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItemsAsync()
        {
            return await dbContext.OrderItems.
                Include(o => o.Order)
                .Include(p => p.Product)
                .ToListAsync();
        }

        public async Task<OrderItem?> GetOrderItemByIdAsync(long id)
        {
            return await dbContext.OrderItems
                .Include(o => o.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<OrderItem>> GetOrderItemByOrderIdAsync(long OrderId)
        {
            return await dbContext.OrderItems
                .Include (p => p.Product)
                .Where(i => i.OrderId == OrderId)
                .ToListAsync();
        }

        public async Task UpdateOrderItemAsync(OrderItem item)
        {
            dbContext.OrderItems.Update(item);
            await dbContext.SaveChangesAsync();
        }
    }
}
