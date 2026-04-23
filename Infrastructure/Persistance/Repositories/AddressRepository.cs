using Domain.Contrats;
using Domain.Entities.Address;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class AddressRepository(EStoreDbContext dbContext) : IAddressRepository
    {
        public async Task AddAddressAsync(Address address)
        {
            await dbContext.Addresses.AddAsync(address);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAddressAsync(Address address)
        {
             dbContext.Addresses.Remove(address);
             await dbContext.SaveChangesAsync();
        }

        public  async Task<IEnumerable<Address>> GetAllAsync()
        {
            return await dbContext.Addresses.ToListAsync();
        }

        public async Task<Address?> GetByIdAsync(long id)
        {
            return await dbContext.Addresses.FindAsync(id);
        }

        public async Task UpdateAddressAsync(Address address)
        {
            dbContext.Addresses.Update(address);
            await dbContext.SaveChangesAsync();
        }
    }
}
