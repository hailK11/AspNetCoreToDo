using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreToDo.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        [required]
        public string Title { get; set;}

        public DateTimeOffset? DueAt { get; set;}
    }
}