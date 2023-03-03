using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;
using ToDoApp.UseCases.Common.Exceptions;

namespace ToDoApp.UseCases.ToDoTasks.Commands.DeleteToDoTask
{
    public class DeleteToDoTaskCommandHandler : IRequestHandler<DeleteToDoTaskCommand, Unit>
    {
        private readonly IDbContext _dbContext;

        public DeleteToDoTaskCommandHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteToDoTaskCommand request, CancellationToken cancellationToken)
        {
            var toDoTask = await _dbContext.ToDoTasks
                .FirstOrDefaultAsync(t => t.UserId == request.UserId && t.Id == request.Id, cancellationToken);

            if (toDoTask == null)
            {
                throw new NotFoundException(nameof(ToDoTask), request.Id);
            }

            _dbContext.ToDoTasks.Remove(toDoTask);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
