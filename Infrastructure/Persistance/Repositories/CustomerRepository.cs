using Domain.Contrats;
using Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class CustomerRepository (EStoreDbContext dbContext): ICustomerRepository
    {
        public async Task AddCustomerAsync(Customer customer)
        {
            await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await dbContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(long id)
        {
            return await dbContext.Customers.FindAsync(id);
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            dbContext.Customers.Update(customer);
            await dbContext.SaveChangesAsync();
        }
    }
}
