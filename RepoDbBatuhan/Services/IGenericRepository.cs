using System.Linq.Expressions;

namespace RepoDbBatuhan.Services
{
    // interface implement edicek sınıflar class olmalı (sınırlandırıyorsun)
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetirHepsi();
        Task<T> GetirById(Guid id);
        Task<bool> Ekle(T entity);
        Task<bool> Sil(Guid id);
        Task<bool> Güncelle(T entity);
        // tahmin edilemez = predicate, kaç tane ne alacağını bilmiyorsan
        Task<IEnumerable<T>> GetirFiltreli(Expression<Func<T, bool>> predicate);
    }
}
