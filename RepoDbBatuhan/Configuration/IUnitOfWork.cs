using RepoDbBatuhan.Services;

namespace RepoDbBatuhan.Configuration
{
    public interface IUnitOfWork
    {
        // interface = tanımlar
        IPersonelRepository Personel { get; } // prop = özellik
        // Veritabanı işlemlerini yap
        Task CompleteAsync(); // method = özellik  
        // anlık rami temizliyor >> garbage collection
        void Dispose();
    }
}
