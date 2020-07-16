using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreToDo.Services;

namespace AspNetCoreToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _todoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _todoItemService = toDoItemService;
        }
       public async Task<IActionResult> Index()
       {
           var items = await _todoItemService.GetIncompleteItemsAsync();
       } 
    }
}