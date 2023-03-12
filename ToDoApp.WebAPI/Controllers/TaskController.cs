using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.UseCases.Features.ToDoTasks.Commands.CreateToDoTask;
using ToDoApp.UseCases.Features.ToDoTasks.Commands.UpdateToDoTask;
using ToDoApp.UseCases.Features.ToDoTasks.Queries.GetSingleToDoTask;

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
        public IActionResult Create(CreateToDoTaskCommand createToDoTask)
        {
            return Json(new { });
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
