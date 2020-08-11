using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemoApp.Controllers
{
    public class AdminManagersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AddManager()
        {
            return View();
        }
        public IActionResult DeleteManager()
        {
            return View();
        }
        public IActionResult UpdateManager()
        {
            return View();
        }
    }
}
