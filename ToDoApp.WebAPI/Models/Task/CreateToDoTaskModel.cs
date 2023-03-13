namespace ToDoApp.WebAPI.Models.Task
{
    public class CreateToDoTaskModel
    {
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
    }
}
