using Microsoft.AspNetCore.Mvc;

namespace EstebanITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
    }
}
