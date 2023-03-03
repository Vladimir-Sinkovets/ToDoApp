using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;
using ToDoApp.UseCases.Common.Exceptions;

namespace ToDoApp.UseCases.ToDoTasks.Commands.UpdateToDoTask
{
    public class UpdateToDoTaskCommandHandler : IRequestHandler<UpdateToDoTaskCommand, Guid>
    {
        private readonly IDbContext _dbContext;

        public UpdateToDoTaskCommandHandler(IDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }

        public async Task<Guid> Handle(UpdateToDoTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _dbContext.ToDoTasks
                .FirstOrDefaultAsync(t => t.UserId == request.UserId && t.Id == request.Id, cancellationToken);

            if (task == null)
            {
                throw new NotFoundException(nameof(ToDoTask), request.Id);
            }

            task.Deadline = request.Deadline;
            task.Text = request.Text;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return task.Id;
        }
    }
}
