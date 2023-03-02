using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities.Models;

namespace ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces
{
    public interface IToDoTaskRepository : IRepository<ToDoTask>
    {
    }
}
