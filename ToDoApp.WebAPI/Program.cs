using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ToDoApp.DataAccess.MsSql;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;
using ToDoApp.UseCases;
using ToDoApp.UseCases.Common.MapperProfiles;
using ToDoApp.WebAPI.Controllers;
using ToDoApp.WebAPI.MappingProfiles;

namespace ToDoApp.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(
                typeof(ToDoTaskMappingProfile),
                typeof(AccountModelsProfile));
            
            builder.Services.AddUseCases();

            
            string connection = builder.Configuration.GetConnectionString("DefaultConnection")!;

            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(connection);
            });

            builder.Services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddTransient<IDbContext, ApplicationDbContext>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}