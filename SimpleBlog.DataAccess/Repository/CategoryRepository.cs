using SimpleBlog.DataAccess.Data;
using SimpleBlog.DataAccess.IRepository;
using SimpleBlog.Models;

namespace SimpleBlog.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            _db.Category.Update(category);
        }
    }
}
