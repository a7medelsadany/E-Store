using Domain.Entities.Order;

namespace Domain.Contrats
{
    public interface IOrderItemRepository
    {
        Task<OrderItem?> GetOrderItemByIdAsync(long id);
        Task<IEnumerable<OrderItem>> GetOrderItemByOrderIdAsync(long OrderId);
        Task<IEnumerable<OrderItem>> GetAllOrderItemsAsync();
        Task AddOrderItemAsync(OrderItem item);
        Task DeleteOrderItemAsync(OrderItem item);
        Task UpdateOrderItemAsync(OrderItem item);
    }
}
