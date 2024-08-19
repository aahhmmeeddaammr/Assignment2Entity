using Assignment2.configurations;
using Assignment2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.DBContext
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database=EntityITI ; Trusted_Connection=True ; Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfugration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Instructor { get; set; }
        public DbSet<Stud_Course> Student_Courses { get; set; }
    }
}
