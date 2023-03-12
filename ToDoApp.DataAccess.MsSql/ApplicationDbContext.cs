using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;

namespace ToDoApp.DataAccess.MsSql
{
    public class ApplicationDbContext : IdentityDbContext<User>, IDbContext
    {
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionsBuilder) : base(optionsBuilder) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        void IDbContext.SaveChanges() => base.SaveChanges();
        async Task IDbContext.SaveChangesAsync(CancellationToken cancellationToken) => await base.SaveChangesAsync(cancellationToken);
        async Task IDbContext.SaveChangesAsync() => await base.SaveChangesAsync();
    }
}
