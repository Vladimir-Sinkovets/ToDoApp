using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.UseCases.Features.Account.Commands.Logout;
using ToDoApp.UseCases.Features.Account.Commands.RegisterUser;
using ToDoApp.UseCases.Features.Account.Commands.SignIn;
using ToDoApp.WebAPI.Models.Account;

namespace ToDoApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AccountController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(LoginModel model)
        {
            var signInCommand = _mapper.Map<SignInCommand>(model);

            var signInResult = await _mediator.Send(signInCommand);

            return Json(new { signInResult.Succeeded }, StatusCodes.Status200OK);
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await _mediator.Send(new LogoutCommand());

            return Ok();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var registerUserCommand = _mapper.Map<RegisterUserCommand>(model);

            var registerResult = await _mediator.Send(registerUserCommand);

            if (registerResult.Succeeded == false)
                return Json(registerResult);


            var signInCommand = _mapper.Map<SignInCommand>(model);

            var signInResult = await _mediator.Send(signInCommand);

            return Json(new { signInResult.Succeeded });
        }
    }
}