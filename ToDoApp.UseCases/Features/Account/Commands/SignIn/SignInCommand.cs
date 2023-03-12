using MediatR;

namespace ToDoApp.UseCases.Features.Account.Commands.SignIn
{
    public class SignInCommand : IRequest<SignInCommandResult>
    {
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
        public string UserName { get; set; }
    }
}
