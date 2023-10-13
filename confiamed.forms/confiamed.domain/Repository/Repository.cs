using Confiamed.Domain.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Confiamed.Domain.Repository
{

    public class Repository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity : class
    {
        private readonly FormDbContext _context;
        private bool _disposed = false;


        public Repository(FormDbContext context)
        {
            _context = context;
        }

        protected DbSet<TEntity> SetEntity
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }
        public async Task<IEnumerable<TEntity>> GetAllListAsync()
        {
            return await SetEntity.ToArrayAsync();
        }
        public IQueryable<TEntity> GetAll()
        {
            return SetEntity.AsQueryable();
        }
        public async Task<TEntity> GetAsync(Tkey id)
        {
            return await SetEntity.FindAsync(id);
        }

        public TEntity Insert(TEntity entity)
        {
            SetEntity.Add(entity);
            return entity;

        }
        public async Task<TEntity> DeleteAsync(Tkey id)
        {
            TEntity entity = await SetEntity.FindAsync(id);
            SetEntity.Remove(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed && disposing)
            {
                _context.Dispose();
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await SetEntity.AsNoTracking().FirstOrDefaultAsync(expression);
        }

    }
}
