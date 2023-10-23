using Microsoft.EntityFrameworkCore;
namespace EstebanITELEC1C.Models;

public class AppDbContext : DbContext
{

    public DbSet<Student> Students { get; set; }
    public DbSet<Instructor> Instructors { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Instructor>().HasData(
            new Instructor()
            {
                Id = 1,
                FirstName = "Aliah",
                LastName = "Esteban",
                IsTenured = true,
                Rank = Rank.Professor,
                HiringDate = DateTime.Parse("05/05/2023")
            },
            new Instructor()
            {
                Id = 2,
                FirstName = "Park",
                LastName = "Jihoon",
                IsTenured = true,
                Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("05/05/2023")
            }

            );

        modelBuilder.Entity<Student>().HasData(
               new Student()
               {
                   Id = 1,
                   FirstName = "Kang",
                   LastName = "Daniel",
                   Course = Course.BSIT,
                   AdmissionDate = DateTime.Parse("2022-08-26"),
                   GPA = 1.5,
                   Email = "kdaniel1@gmail.com"
               },
                new Student()
                {
                    Id = 2,
                    FirstName = "Park",
                    LastName = "Jihoon",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "pjihoon@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Lee",
                    LastName = "Daehwi",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "leedaehwi12@gmail.com"
                }

           );
    }
}
