using Domain.Contrats;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using System.Linq.Expressions;

namespace Persistance.Repositories
{
    public class GenericRepository<TEntity> (EStoreDbContext _dbContext): IGenericRepository<TEntity> where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(long id) => await _dbContext.Set<TEntity>().FindAsync(id);
             
        public void Remove(TEntity entity)=>_dbContext.Set<TEntity>().Remove(entity);

        public async Task SaveAsync(TEntity entity)=>await _dbContext.Set<TEntity>().AddAsync(entity);

        public async Task SaveChangesAsync()=>
            await _dbContext.SaveChangesAsync();


        public void Update(TEntity entity)=>_dbContext.Set<TEntity>().Update(entity);

        
    }
}
