using Microsoft.EntityFrameworkCore;
using RepoDbBatuhan.Model;

namespace RepoDbBatuhan.Data
{
    public class RepoDbBatuhanContext : DbContext
    {
        public RepoDbBatuhanContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Personel> Personeller { get; set; }
    }
}
