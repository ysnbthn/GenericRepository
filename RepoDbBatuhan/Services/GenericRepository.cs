using Microsoft.EntityFrameworkCore;
using RepoDbBatuhan.Data;
using System.Linq.Expressions;

namespace RepoDbBatuhan.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected RepoDbBatuhanContext context;
        internal DbSet<T> dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(RepoDbBatuhanContext context, ILogger logger)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            _logger = logger;
        }

        public Task<IEnumerable<T>> GetirHepsi()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetirById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Ekle(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Sil(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Güncelle(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetirFiltreli(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
