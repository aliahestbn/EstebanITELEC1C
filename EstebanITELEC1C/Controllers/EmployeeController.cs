using Microsoft.AspNetCore.Mvc;

namespace EstebanITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
