using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.UseCases.Account.Commands.RegisterUser
{
    public class RegisterUserCommandResult
    {
        public bool IsSuccessed { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
