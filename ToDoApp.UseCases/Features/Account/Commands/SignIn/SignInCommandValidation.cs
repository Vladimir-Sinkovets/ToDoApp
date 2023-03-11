using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
