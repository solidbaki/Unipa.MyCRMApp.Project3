using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MvcCoreDemoApp.Controllers
{
    public class AdminAddDepartmentController : Controller
    {
        public string inputDepartmentName { get; set; }
        public string inputDepartmentManager { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
