using MediatR;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;

namespace ToDoApp.UseCases.Features.ToDoTasks.Commands.CreateToDoTask
{
    public class CreateToDoTaskCommandHandler : IRequestHandler<CreateToDoTaskCommand, Guid>
    {
        private readonly IDbContext _dbContext;

        public CreateToDoTaskCommandHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateToDoTaskCommand request, CancellationToken cancellationToken)
        {
            var newToDoTask = new ToDoTask()
            {
                Id = Guid.NewGuid(),
                Deadline = request.Deadline,
                Text = request.Text,
                UserId = request.UserId,
            };

            await _dbContext.ToDoTasks.AddAsync(newToDoTask, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return newToDoTask.Id;
        }
    }
}
