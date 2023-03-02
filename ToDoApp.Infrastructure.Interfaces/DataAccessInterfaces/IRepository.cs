namespace ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
