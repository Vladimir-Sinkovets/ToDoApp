namespace ToDoApp.WebAPI.Models.Task
{
    public class UpdateToDoTaskModel
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
    }
}
