namespace ToDoApp.Entities.Models
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}