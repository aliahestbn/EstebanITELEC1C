using Microsoft.AspNetCore.Mvc;
using EstebanITELEC1C.Models;


namespace EstebanITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Kang",LastName = "Daniel", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "kdaniel1@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Park",LastName = "Jihoon", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "pjihoon@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Lee",LastName = "Daehwi", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "leedaehwi12@gmail.com"
                }
            };
        public IActionResult Index()
        {
            
            return View(StudentList);
        }

        public IActionResult Student()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }

    }
}

