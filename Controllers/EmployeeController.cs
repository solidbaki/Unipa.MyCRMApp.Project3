using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateTask()
        {
            return View();
        }
        public IActionResult TaskClosure()
        {
            return View();
        }
    }
}
