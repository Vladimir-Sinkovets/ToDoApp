using FluentValidation;

namespace ToDoApp.UseCases.Features.Account.Commands.RegisterUser
{
    public class RegisterUserCommandValidation : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty();

            RuleFor(x => x.Password)
                .NotEmpty();

            RuleFor(x => x.UserName)
                .NotEmpty();
        }
    }
}
