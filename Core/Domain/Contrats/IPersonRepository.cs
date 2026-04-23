using Domain.Entities.Customer;

namespace Domain.Contrats
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(long id);
        Task<IEnumerable<Person>> GetAllAsync();
        Task AddPersonAsync(Person person);
        Task DeletePersonAsync(Person person);
        Task UpdatePersonAsync(Person person);
    }
}
