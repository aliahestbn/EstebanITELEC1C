using Microsoft.AspNetCore.Mvc;
using EstebanITELEC1C.Models;
using EstebanITELEC1C.Services;

namespace EstebanITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        public StudentController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }

        public IActionResult Index()
        {

            return View(_fakeData.StudentList);
        }

        public IActionResult Student()
        {

            return View(_fakeData.StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

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
            _fakeData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditStudent(Student studentChange)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == studentChange.Id);
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
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Student removeStudent)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == removeStudent.Id);
            if (student != null)
            {
                 _fakeData.StudentList.Remove(student);
            }
            return RedirectToAction("Index");
        }
    }
}



