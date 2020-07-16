using System;
using System.Threading.Tasks;
using AspNetCoreToDo.Models;

namespace AspNetCoreToDo.Services
{
    public class FakeToDoItemService : IToDoItemService
    {
        public Task<ToDoItem[]> GetIncompleteItemsAsync()
        {
            var Item1 = new ToDoItem{
                Title = "Task 1",
                DueAt = DateTimeOffset.Now.AddDays(5)
            };

           var Item2= new ToDoItem{
                Title = "Task 2",
                DueAt = DateTimeOffset.Now.AddDays(2)
            }; 

            return Task.FromResult(new [] {Item1, Item2});
        }
    }
}