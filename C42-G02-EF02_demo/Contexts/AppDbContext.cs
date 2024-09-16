using C42_G02_EF02_demo.Configurations;
using C42_G02_EF02_demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01_assignment.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = HASAN\\MSSQLSERVER09; Database = ITI; Trusted_Connection = true; TrustServerCertificate = true");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new InstructorConfigurations());
            modelBuilder.ApplyConfiguration(new CourseConfigurations());
            
            modelBuilder.Entity<CourseInstructor>()
                        .HasKey(c => new { c.CourseID, c.InstructorID});
            
            modelBuilder.Entity<StudentCourse>()
                        .HasKey(S => new { S.StudentID, S.CourseID});

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Course> Courses { get; set; } //represents table not view
        public DbSet<Department> Departments { get; set; }
        public DbSet<CourseInstructor> CoursesInstructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
