using Microsoft.AspNetCore.Mvc;

namespace SignalR.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }
    }
}
