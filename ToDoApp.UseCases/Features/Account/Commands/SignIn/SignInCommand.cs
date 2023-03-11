using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities.Models;

namespace ToDoApp.UseCases.Features.Account.Commands.SignIn
{
    public class SignInCommand : IRequest<SignInCommandResult>
    {
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
        public string UserName { get; set; }
    }
}
