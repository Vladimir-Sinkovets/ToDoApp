namespace ToDoApp.UseCases.ToDoTasks.Queries.GetSingleToDoTask
{
    public class ToDoTaskDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
    }
}
