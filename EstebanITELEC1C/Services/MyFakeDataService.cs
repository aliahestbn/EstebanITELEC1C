using System;
using EstebanITELEC1C.Models;
using EstebanITELEC1C.Services;

namespace PalomoITELEC1C.Services

{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        //constructor
        public MyFakeDataService()
        {

           StudentList = new List<Student>
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

          InstructorList = new List<Instructor>() {
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

        }

    }
}