using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.UseCases.ToDoTasks.Commands.UpdateToDoTask
{
    public class UpdateToDoTaskCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
    }
}
