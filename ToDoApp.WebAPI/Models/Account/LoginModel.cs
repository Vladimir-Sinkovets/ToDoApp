namespace ToDoApp.WebAPI.Models.Account
{
    public class LoginModel
    {
        public bool IsPersistent { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
