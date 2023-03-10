using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.UseCases.Account.Commands.RegisterUser
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
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
