using System.Threading.Tasks;
using WebApplication2.Repository;
using WebApplication2.Repository.AuthorRepository;
using WebApplication2.Repository.ImageRepository;

namespace WebApplication2.UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiContext _context;
        public UnitOfWork(ApiContext context)
        {
            _context = context;
        }

        public IImageRepository ImageRepository => new ImageRepository(_context);
        public IAuthorRepository AuthorRepository => new AuthorRepository(_context);
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
