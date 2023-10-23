using Microsoft.AspNetCore.Mvc;
using EstebanITELEC1C.Models;
using EstebanITELEC1C.Services;

namespace EstebanITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            return View(_dbContext.Students);
        }

        public IActionResult Student()
        {

            return View(_dbContext.Students);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

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
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditStudent(Student studentChange)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == studentChange.Id);
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
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Student removeStudent)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == removeStudent.Id);
            if (student != null)
            {
                 _dbContext.Students.Remove(student);
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}



