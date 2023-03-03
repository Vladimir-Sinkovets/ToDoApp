using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;

namespace ToDoApp.UseCases.ToDoTasks.Queries.GetSingleToDoTask
{
    internal class GetSingleToDoTaskQueryHandler : IRequestHandler<GetSingleToDoTaskQuery, ToDoTaskDto>
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetSingleToDoTaskQueryHandler(IDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ToDoTaskDto> Handle(GetSingleToDoTaskQuery request, CancellationToken cancellationToken)
        {
            var toDoTask = await _dbContext.ToDoTasks
                .FirstOrDefaultAsync(t => t.Id == request.Id && t.UserId == request.UserId, cancellationToken);

            var dto = _mapper.Map<ToDoTaskDto>(toDoTask);

            return dto;
        }
    }
}
