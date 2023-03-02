namespace ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces
{
    public interface IUnitOfWork
    {
        IToDoTaskRepository ToDoTaskRepository { get; }
        IToDoTaskDataRepository ToDoTaskDataRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
