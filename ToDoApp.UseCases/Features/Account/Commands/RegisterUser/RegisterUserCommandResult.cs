using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.UseCases.Features.Account.Commands.RegisterUser
{
    public class RegisterUserCommandResult
    {
        public bool Succeeded { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
