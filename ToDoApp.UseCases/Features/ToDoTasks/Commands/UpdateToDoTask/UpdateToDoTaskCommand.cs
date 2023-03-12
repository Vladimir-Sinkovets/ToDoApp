using MediatR;

namespace ToDoApp.UseCases.Features.ToDoTasks.Commands.UpdateToDoTask
{
    public class UpdateToDoTaskCommand : IRequest<Guid>
    {
        public string UserId { get; set; }
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
    }
}
