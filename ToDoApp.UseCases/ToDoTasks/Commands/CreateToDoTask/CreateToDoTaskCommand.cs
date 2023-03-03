﻿using MediatR;

namespace ToDoApp.UseCases.ToDoTasks.Commands.CreateToDoTask
{
    public class CreateToDoTaskCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
    }
}