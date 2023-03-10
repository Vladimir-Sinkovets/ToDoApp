using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.UseCases.Account.Commands.RegisterUser;

namespace ToDoApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("logout")]
        public IActionResult Logout()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterUserCommand registerUserCommand)
        {
            var result = await _mediator.Send(registerUserCommand);

            return result.IsSuccessed == true ? 
                Json(new { result.IsSuccessed }) : 
                Json(result);
        }
    }
}
