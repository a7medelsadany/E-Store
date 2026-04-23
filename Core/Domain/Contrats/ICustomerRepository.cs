using Domain.Entities.Customer;

namespace Domain.Contrats
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(long id);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task AddCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
    }
}
