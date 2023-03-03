using Microsoft.EntityFrameworkCore;
using ToDoApp.Entities.Models;

namespace ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces
{
    public interface IDbContext
    {
        DbSet<ToDoTask> ToDoTasks { get; }

        void SaveChanges();
        Task SaveChangesAsync(CancellationToken cancellationToken);
        Task SaveChangesAsync();
    }
}
