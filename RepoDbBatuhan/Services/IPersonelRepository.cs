using RepoDbBatuhan.Model;

namespace RepoDbBatuhan.Services
{
    // inherit edilen class + kendi aracı interface'in
    public interface IPersonelRepository : IGenericRepository<Personel>
    {
        // Personele özel metod tanımları
        Task<Personel> KayıplarıGetir();
    }
}
