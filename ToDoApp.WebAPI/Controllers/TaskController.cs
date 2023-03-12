using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.UseCases.Features.ToDoTasks.Commands.CreateToDoTask;
using ToDoApp.UseCases.Features.ToDoTasks.Commands.UpdateToDoTask;
using ToDoApp.UseCases.Features.ToDoTasks.Queries.GetSingleToDoTask;
using ToDoApp.WebAPI.Models.Task;

namespace ToDoApp.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : BaseController
    {
        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var getSingleToDoTaskQuery = new GetSingleToDoTaskQuery()
            {
                Id = Guid.Parse(id),
                UserId = UserId,
            };

            var singleTask = await _mediator.Send(getSingleToDoTaskQuery);

            return Json(singleTask);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(CreateToDoTaskModel model)
        {
            var createToDoTask = new CreateToDoTaskCommand
            {
                Deadline = model.Deadline,
                UserId = UserId,
                Text = model.Text,
            };

            var newTodoTaskId = await _mediator.Send(createToDoTask);

            return Json(new { NewId = newTodoTaskId });
        }
        
        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(string id)
        {
            return Json(new { });
        }
        
        [HttpPost]
        [Route("update")]
        public IActionResult Upadate(UpdateToDoTaskCommand updateToDoTask)
        {
            return Json(new { });
        }
    }
}
