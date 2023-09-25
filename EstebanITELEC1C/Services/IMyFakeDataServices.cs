using EstebanITELEC1C.Models;

namespace EstebanITELEC1C.Services { 
        public interface IMyFakeDataService
        {
            List<Student> StudentList { get; }
            List<Instructor> InstructorList { get; }
        }
    }
