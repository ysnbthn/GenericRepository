using Microsoft.EntityFrameworkCore;
using RepoDbBatuhan.Data;
using RepoDbBatuhan.Model;

namespace RepoDbBatuhan.Services
{
    // genel fonksiyon tanımları + özel fonksiyon tanımları
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        // inherit edilen base classda olduğu için tekrar dependency injectiona gerek yok
        public PersonelRepository(RepoDbBatuhanContext context, ILogger logger) : base(context, logger) // üste gönder inject etsin
        {
        }

        public override async Task<IEnumerable<Personel>> GetirHepsi()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Hatalar: ", typeof(PersonelRepository));
                // boş liste at çalışmaya devam et
                return new List<Personel>();
            }
        }

        public Task<Personel> KayıplarıGetir()
        {
            throw new NotImplementedException();
        }

    }
}
