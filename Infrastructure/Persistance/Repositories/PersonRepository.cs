using Domain.Contrats;
using Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Persistance.Repositories
{
    public class PersonRepository(EStoreDbContext dbContext) : IPersonRepository
    {
        public async Task AddPersonAsync(Person person)
        {
            await dbContext.People.AddAsync(person);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeletePersonAsync(Person person)
        {
            dbContext.People.Remove(person);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await dbContext.People.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(long id)
        {
            return await dbContext.People.FindAsync(id);
        }

        public async Task UpdatePersonAsync(Person person)
        {
            dbContext.People.Update(person);
            await dbContext.SaveChangesAsync();
        }
    }
}
