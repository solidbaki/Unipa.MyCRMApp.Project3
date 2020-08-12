using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemoApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Department()
        {
            return View("~/Views/Admin/AdminDepartment/Index.cshtml");
        }
        public IActionResult Employee()
        {
            return View("~/Views/Admin/AdminEmployees/Index.cshtml");
        }
        public IActionResult Manager()
        {
            return View("~/Views/Admin/AdminManagers/Index.cshtml");
        }
    }
}
