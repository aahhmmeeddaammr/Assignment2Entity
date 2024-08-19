using Assignment2.DBContext;
using Assignment2.Entities;
using System.Net;

namespace Assignment2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region MyRegion
            using ITIDbContext iTIDbContext = new ITIDbContext();

            #region Create
            // iTIDbContext.Students.AddRange(new Student[]
            // {
            //     new Student { FName = "Ahmed", LName = "Amr", Address = "Cairo", Age = 20},
            //     new Student {  FName = "Samir", LName = "Samy", Address = "Giza", Age = 23 },
            //     new Student { FName = "Fawzii", LName = "Ayman", Address = "Alex", Age = 21 },
            //     new Student { FName = "Nada", LName = "Badawy", Address = "Cairo", Age = 24 }


            // });
            // iTIDbContext.AddRange(new Topic[]
            //{
            //         new Topic { Name = "Science" },
            //         new Topic { Name = "Humanities" },
            //         new Topic { Name = "Arts" },
            //         new Topic { Name = "Engineering" },
            //         new Topic { Name = "Mathematics" }

            //});

            //iTIDbContext.AddRange(new Course[]
            //{
            //     new Course { Duration = 10, Name = "Math 101", Description = "Basic Math"  , Topic = iTIDbContext.Topics.First()},
            //     new Course {Duration = 8, Name = "History 101", Description = "World History"   , Topic = iTIDbContext.Topics.ToArray()[2]},
            //     new Course {Duration = 12, Name = "Physics 101", Description = "Basic Physics"  , Topic = iTIDbContext.Topics.ToArray()[2]},
            //     new Course {  Duration = 6, Name = "Chemistry 101", Description = "Basic Chemistry" , Topic = iTIDbContext.Topics.ToArray()[3]},
            //     new Course {  Duration = 9, Name = "English 101", Description = "English Literature"  , Topic = iTIDbContext.Topics.First()}
            //});



            // iTIDbContext.AddRange(new Instructor[]
            // {
            //      new Instructor {  Name = "Dr. Smith", Bonus = 500, Salary = 80000, Address = "123 Main St", HourRate = 50},
            //  new Instructor {        Name = "Dr. Johnson", Bonus = 600, Salary = 90000, Address = "456 Elm St", HourRate = 55  },
            //  new Instructor {         Name = "Dr. Williams", Bonus = 550, Salary = 85000, Address = "789 Oak St", HourRate = 52 },
            //  new Instructor {          Name = "Dr. Brown", Bonus = 650, Salary = 95000, Address = "101 Pine St", HourRate = 267},
            //  new Instructor {           Name = "Dr. Jones", Bonus = 700, Salary = 100000, Address = "202 Maple St", HourRate = 60 }

            // });
            //iTIDbContext.AddRange(new Department[]
            //{
            //     new Department {  Name = "Science Dept" ,Instructor = iTIDbContext.Instructors.Where(i=>true).ToArray()[1]},
            //     new Department { Name = "Arts Dept" , Instructor = iTIDbContext.Instructors.Where(i => true).ToArray()[2]},
            //     new Department {  Name = "Engineering Dept" , Instructor = iTIDbContext.Instructors.Where(i => true).First()},
            //     new Department {  Name = "Humanities Dept" , Instructor = iTIDbContext.Instructors.Where(i => true).ToArray()[3]},
            //     new Department {  Name = "Math Dept" , Instructor = iTIDbContext.Instructors.Where(i => true).ToArray().Last()}
            //    });

            iTIDbContext.AddRange(new Stud_Course[]
            {
             new Stud_Course { Student =iTIDbContext.Students.Where(i=>true).ToArray()[2] , Course= iTIDbContext.Courses.Where(i=>true).ToArray()[2],  Grade = 75 },
             new Stud_Course { Student =iTIDbContext.Students.Where(i=>true).ToArray()[1] , Course= iTIDbContext.Courses.Where(i=>true).ToArray()[1],  Grade = 75 },
             new Stud_Course { Student =iTIDbContext.Students.Where(i=>true).ToArray()[1] , Course= iTIDbContext.Courses.Where(i=>true).ToArray()[2],  Grade = 75 },
            }
            );

            iTIDbContext.AddRange(new Course_Inst[]{
             new Course_Inst { Instructor =iTIDbContext.Instructors.Where(i=>true).ToArray()[2] , Course= iTIDbContext.Courses.Where(i=>true).ToArray()[2], Evaluate = "Good" },
             new Course_Inst { Instructor =iTIDbContext.Instructors.Where(i=>true).ToArray()[0] , Course= iTIDbContext.Courses.Where(i=>true).ToArray()[1], Evaluate = "Good" },
             new Course_Inst { Instructor =iTIDbContext.Instructors.Where(i=>true).ToArray()[1] , Course= iTIDbContext.Courses.Where(i=>true).ToArray()[3], Evaluate = "Good" },
               });
            #endregion



            #region Read

            //var CI = iTIDbContext.Course_Instructor.First();
            #endregion

            #region Delete

            //iTIDbContext.Remove(CI);
            #endregion

            #region Ubdate
            //var St =  iTIDbContext.Students.First();
            //St.LName = "Route";
            #endregion
            iTIDbContext.SaveChanges();

            #endregion
        }
    }
}
