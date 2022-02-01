using Microsoft.EntityFrameworkCore;
using RepoDbBatuhan.Data;
using System.Linq.Expressions;

namespace RepoDbBatuhan.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly RepoDbBatuhanContext _context; // database
        private readonly DbSet<T> _dbSet; // database tablosu

        public GenericRepository(RepoDbBatuhanContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        // virtual = override edilebilir
        public virtual async Task<bool> Ekle(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<T> GetirById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetirFiltreli(Expression<Func<T, bool>> predicate)
        {
            // geleni arat listele
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetirHepsi()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task<bool> Güncelle(T entity)
        {
            _dbSet.Update(entity);
            return true;
        }

        public virtual async Task<bool> Sil(Guid id)
        {
            _dbSet.Remove(await _dbSet.FindAsync(id));
            return true;
        }        
    }
}
