using System;
using System.Threading.Tasks;
using AspNetCoreToDo.Models;

namespace AspNetCoreToDo.Services
{
    public interface IToDoItemService
    {
        Task<ToDoItem[]> GetIncompleteItemsAsync();
    }
}