using Domain.Entities.Order;

namespace Domain.Contrats
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrderByIdAsync(long id);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(Order order);
    }
}
