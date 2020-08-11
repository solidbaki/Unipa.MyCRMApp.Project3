using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemoApp.Controllers
{
    public class AdminDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "Hello from admindepartment";
        }

        // AdminDepartment/AddDepartment
        public IActionResult AddDepartment()
        {
            return View();
        }
        // AdminDepartment/DeleteDepartment
        public IActionResult DeleteDepartment()
        {
            return View();
        }
        // AdminDepartment/UpdateDepartment
        public IActionResult UpdateDepartment()
        {
            return View();
        }

    }
}
