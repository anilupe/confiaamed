using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Confiamed.Domain.Repository
{
   
        public interface IRepository<TEntity, Tkey> : IDisposable where TEntity : class
        {
            IQueryable<TEntity> GetAll();
            Task<IEnumerable<TEntity>> GetAllListAsync();
            Task<TEntity> GetAsync(Tkey id);
            TEntity Insert(TEntity entity);
            Task<TEntity> DeleteAsync(Tkey id);
            TEntity Update(TEntity entity);
            Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> expression);

        }
    
}
