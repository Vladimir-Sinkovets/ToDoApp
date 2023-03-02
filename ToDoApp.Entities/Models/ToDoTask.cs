namespace ToDoApp.Entities.Models
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public DateTime Deadline { get; set; }
        public ToDoTaskData Data { get; set; }

    }
}