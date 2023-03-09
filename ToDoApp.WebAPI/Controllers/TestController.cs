using Microsoft.AspNetCore.Mvc;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;

namespace ToDoApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private IDbContext _dbContext;

        public TestController(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //_dbContext.ToDoTasks.Add(new ToDoTask() { Text = "12312" });

            //_dbContext.SaveChanges();

            var list = _dbContext.ToDoTasks.ToList();

            return Json(new { List = list });
        }
    }
}
