namespace SimpleBlog.DataAccess.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category {  get; }
        Task SaveAsync(); 
    }
}
