using MediatR;

namespace ToDoApp.UseCases.Features.ToDoTasks.Commands.DeleteToDoTask
{
    public class DeleteToDoTaskCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
    }
}
