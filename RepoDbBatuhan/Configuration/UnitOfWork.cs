using RepoDbBatuhan.Data;
using RepoDbBatuhan.Services;

namespace RepoDbBatuhan.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly RepoDbBatuhanContext _context;
        private readonly ILogger _logger;

        public IPersonelRepository Personel { get; private set; }

        public UnitOfWork(RepoDbBatuhanContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");
            // polymorphism 
            Personel = new PersonelRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
