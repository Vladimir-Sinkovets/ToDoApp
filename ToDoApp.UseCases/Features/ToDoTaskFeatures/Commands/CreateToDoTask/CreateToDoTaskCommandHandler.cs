using MediatR;
using ToDoApp.Entities.Models;
using ToDoApp.Infrastructure.Interfaces.DataAccessInterfaces;

namespace ToDoApp.UseCases.Features.ToDoTaskFeatures.Commands.CreateToDoTask
{
    public class CreateToDoTaskCommandHandler : IRequestHandler<CreateToDoTaskCommand, Guid>
    {
        private readonly IToDoTaskDataRepository _doTaskDataRepository;
        private readonly IToDoTaskRepository _toDoTaskRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateToDoTaskCommandHandler(IUnitOfWork unitOfWork)
        {
            _doTaskDataRepository = unitOfWork.ToDoTaskDataRepository;
            _toDoTaskRepository= unitOfWork.ToDoTaskRepository;
            this._unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateToDoTaskCommand request, CancellationToken cancellationToken)
        {
            var newToDoTaskData = new ToDoTaskData()
            {
                Text = request.Text,
                Id = Guid.NewGuid(),
            };

            var newToDoTask = new ToDoTask()
            {
                Data= newToDoTaskData,
                Deadline= request.Deadline,
                Id = Guid.NewGuid(),
            };

            _toDoTaskRepository.Create(newToDoTask);
            _doTaskDataRepository.Create(newToDoTaskData);

            await _unitOfWork.SaveChangesAsync();

            return newToDoTask.Id;
        }
    }
}
