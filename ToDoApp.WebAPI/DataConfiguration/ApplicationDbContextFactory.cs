using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ToDoApp.DataAccess.MsSql;

namespace ToDoApp.WebAPI.DataConfiguration
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDoApp;Trusted_Connection=True");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
