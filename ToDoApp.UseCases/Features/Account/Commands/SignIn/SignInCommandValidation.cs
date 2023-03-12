using FluentValidation;

namespace ToDoApp.UseCases.Features.Account.Commands.SignIn
{
    internal class SignInCommandValidation : AbstractValidator<SignInCommand>
    {
        public SignInCommandValidation()
        {
            RuleFor(x => x.Password)
                .NotEmpty();

            RuleFor(x => x.UserName)
                .NotEmpty();
        }
    }
}
