using NetCoreWebAPI.Data;
using NetCoreWebAPI.Repository.Interfaces;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Repository
{
    public class Repository : IRepository
    {
        private readonly EventContext _context;

        public Repository(EventContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
