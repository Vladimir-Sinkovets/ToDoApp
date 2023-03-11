using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.UseCases.Features.ToDoTasks.Commands.DeleteToDoTask
{
    public class DeleteToDoTaskCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
    }
}
