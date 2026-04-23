using Domain.Entities.Address;

namespace Domain.Contrats
{
    public interface IAddressRepository
    {
        Task<Address?> GetByIdAsync(long id);
        Task<IEnumerable<Address>> GetAllAsync();
        Task AddAddressAsync(Address address);
        Task UpdateAddressAsync(Address address);
        Task DeleteAddressAsync(Address address);
    }
}
