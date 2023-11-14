using EstebanITELEC1C.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EstebanITELEC1C.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Steve",
                    LastName = "De Vera",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2012-03-04"),
                    GPA = 1.5,
                    Email = "steve.devera.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Gab",
                    LastName = "Montano",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2012-03-04"),
                    GPA = 1.5,
                    Email = "gab.montano.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Kobe",
                    LastName = "Irving",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2012-03-04"),
                    GPA = 1.5,
                    Email = "kobe.irving.cics@ust.edu.ph"
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Gab",
                    LastName = "Montano",
                    IsTenured = true,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("05/06/2078")
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "James",
                    LastName = "Durant",
                    IsTenured = false,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("05/06/2078")
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Leo",
                    LastName = "Lintag",
                    IsTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("05/06/2078")
                }
            );
        }
    }
}