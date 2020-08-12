using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDemoApp.Controllers
{
    public class AdminDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // AdminDepartment/AddDepartment
        public IActionResult AddDepartment()
        {
            return View("~/Views/Admin/AdminDepartment/AddDepartment.cshtml");
        }
        // AdminDepartment/DeleteDepartment
        public IActionResult DeleteDepartment()
        {
            return View("~/Views/Admin/AdminDepartment/DeleteDepartment.cshtml");
        }
        // AdminDepartment/UpdateDepartment
        public IActionResult UpdateDepartment()
        {
            return View("~/Views/Admin/AdminDepartment/UpdateDepartment.cshtml");
        }

    }
}
