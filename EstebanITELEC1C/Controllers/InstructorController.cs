using EstebanITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstebanITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>() {
            new Instructor()
                {
                Id= 1,
                FirstName="Aliah",
                LastName="Esteban",
                IsTenured=true,
                Rank=Rank.Professor,
                HiringDate=DateTime.Parse("05/05/2023")
            },
            new Instructor()
                {
                    Id= 2,
                FirstName="Park",
                LastName="Jihoon",
                IsTenured=true,
                Rank=Rank.AssistantProfessor,
                HiringDate=DateTime.Parse("05/05/2023")
            }

            };


        public IActionResult Instructor()
        {

            return View(InstructorList);

        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
    }
}
