using SimpleBlog.Models;

namespace SimpleBlog.DataAccess.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
