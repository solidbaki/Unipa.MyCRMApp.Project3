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
            return View("~/Views/Admin/AdminManagers/Index.cshtml");
        }
        
        public IActionResult AddManager()
        {
            return View("~/Views/Admin/AdminManagers/AddManager.cshtml");
        }
        public IActionResult DeleteManager()
        {
            return View("~/Views/Admin/AdminManagers/DeleteManager.cshtml");
        }
        public IActionResult UpdateManager()
        {
            return View("~/Views/Admin/AdminManagers/UpdateManager.cshtml");
        }
    }
}
