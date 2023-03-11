using MediatR;
using Microsoft.AspNetCore.Identity;
using ToDoApp.Entities.Models;

namespace ToDoApp.UseCases.Features.Account.Commands.SignIn
{
    public class SignInCommandHandler : IRequestHandler<SignInCommand, SignInCommandResult>
    {
        private readonly SignInManager<User> _signInManager;

        public SignInCommandHandler(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<SignInCommandResult> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(
                request.UserName,
                request.Password,
                request.IsPersistent,
                lockoutOnFailure: false);

            return new SignInCommandResult()
            {
                Succeeded = result.Succeeded,
            };
        }
    }
}
