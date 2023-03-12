namespace ToDoApp.UseCases.Features.Account.Commands.RegisterUser
{
    public class RegisterUserCommandResult
    {
        public bool Succeeded { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
