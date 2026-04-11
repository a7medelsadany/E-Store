using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contrats
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity> GetByIdAsync(long id);
        Task SaveAsync(TEntity entity);  
        void Update(TEntity entity);
        void Remove(TEntity entity);

        Task SaveChangesAsync();
    }
}
