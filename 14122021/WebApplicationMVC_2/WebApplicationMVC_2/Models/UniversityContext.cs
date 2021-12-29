using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC_2.Models;

namespace WebApplicationMVC_2.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
           Database.EnsureCreated();          
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user1";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";

            // добавляем роли
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role emplRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, emplRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
        */
        public DbSet<WebApplicationMVC_2.Models.Course> Courses { get; set; }

        public DbSet<WebApplicationMVC_2.Models.Group> Groups { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Employee> Employees { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Student> Students { get; set; }  
        public DbSet<WebApplicationMVC_2.Models.TrainingType> TrainingTypes { get; set; }
        public DbSet<WebApplicationMVC_2.Models.WorkStatus> WorkStatuses { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Reason> Reasons { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Value> Values { get; set; }
        public DbSet<WebApplicationMVC_2.Models.ScholarshipType> ScholarshipTypes { get; set; }
        public DbSet<WebApplicationMVC_2.Models.MarkType> MarkTypes { get; set; }
        public DbSet<WebApplicationMVC_2.Models.ActivityType> ActivityTypes { get; set; }
        public DbSet<WebApplicationMVC_2.Models.EducationalForm> EducationalForms { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Mark> Marks { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Visit> Visits { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Activity> Activities { get; set; }
        public DbSet<WebApplicationMVC_2.Models.GraduateWork> GraduateWorks { get; set; }
        public DbSet<WebApplicationMVC_2.Models.User> Users { get; set; }
        public DbSet<WebApplicationMVC_2.Models.Role> Roles { get; set; }
    }
}
