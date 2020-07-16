using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreToDo.Models;
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

           var model = new ToDoViewModel
           {
               ToDoItems = items
           };

           return View(model);
       } 
    }
}