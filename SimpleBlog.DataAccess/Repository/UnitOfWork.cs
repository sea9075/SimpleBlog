using SimpleBlog.DataAccess.Data;
using SimpleBlog.DataAccess.IRepository;

namespace SimpleBlog.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category {  get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();    
        }
    }
}
