using MediatR;

namespace ToDoApp.UseCases.Features.ToDoTask.Commands.CreateToDoTask
{
    public class CreateToDoTaskCommandHandler : IRequestHandler<CreateToDoTaskCommand, Guid>
    {
        public Task<Guid> Handle(CreateToDoTaskCommand request, CancellationToken cancellationToken)
        {
            
            return default;
        }
    }
}
