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

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditStudent(Student studentChange)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChange.Id);
            if (student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Email = studentChange.Email;
                student.GPA = studentChange.GPA;
                student.Course = studentChange.Course;
                student.AdmissionDate = studentChange.AdmissionDate;
            }
            return View("Index", StudentList);

        }
    }
}

