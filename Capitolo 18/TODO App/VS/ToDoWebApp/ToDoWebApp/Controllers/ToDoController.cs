using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Models;

namespace ToDoWebApp.Controllers
{
    [Authorize]
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            TodoActivityViewModel model = new TodoActivityViewModel();
            model.Activities.Add(new TodoActivity("Test 1") { });
            model.Activities.Add(new TodoActivity("Test 2") { Date = new DateTime(2020,01,26), Completed = true });
            return View(model);
        }
    }
}