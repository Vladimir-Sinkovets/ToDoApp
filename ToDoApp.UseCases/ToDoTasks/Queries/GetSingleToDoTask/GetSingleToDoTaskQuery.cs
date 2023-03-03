using MediatR;

namespace ToDoApp.UseCases.ToDoTasks.Queries.GetSingleToDoTask
{
    public class GetSingleToDoTaskQuery : IRequest<ToDoTaskDto>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
