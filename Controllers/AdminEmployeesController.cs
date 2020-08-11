using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemoApp.Controllers
{
    public class AdminEmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpdateEmployee()
        {
            return View();
        }
    }
}
