using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Tests;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Users;

namespace WebApi.Models.Domain
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        //public DbSet<Test> Tests { get; set; }
        //public DbSet<UserInfo> UsersInfo { get; set; }
        //public DbSet<TestInfo> TestsInfo { get; set; }
        //public DbSet<UserAnswer> UserAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Ignore(b => b.UserName);
            modelBuilder.Entity<User>().Ignore(b => b.NormalizedUserName);
            modelBuilder.Entity<User>().Ignore(b => b.LockoutEnabled);
            modelBuilder.Entity<User>().Ignore(b => b.LockoutEnd);
            modelBuilder.Entity<User>().Ignore(b => b.NormalizedEmail);
            modelBuilder.Entity<User>().Ignore(b => b.NormalizedUserName);
            modelBuilder.Entity<User>().Ignore(b => b.Password);
            modelBuilder.Entity<User>().Ignore(b => b.PhoneNumber);
            modelBuilder.Entity<User>().Ignore(b => b.PhoneNumberConfirmed);
            modelBuilder.Entity<User>().Ignore(b => b.SecurityStamp);
            modelBuilder.Entity<User>().Ignore(b => b.TwoFactorEnabled);
            modelBuilder.Entity<User>().Ignore(b => b.EmailConfirmed);
            modelBuilder.Entity<User>().Ignore(b => b.ConcurrencyStamp);
            modelBuilder.Entity<User>().Ignore(b => b.AccessFailedCount);
            //string adminRoleName = "admin";
            //string studentRoleName = "student";
            //string superAdmin = "super_admin";
            //string teacherRoleName = "teacher";

            //string adminEmail = "admin@mail.ru";
            //string adminPassword = "123456";

            //Role superAdminRole = new Role { Id = Guid.NewGuid(), RoleName = superAdmin };
            //Role studentRole = new Role { Id = Guid.NewGuid(), RoleName = studentRoleName };
            //Role teacherRole = new Role { Id = Guid.NewGuid(), RoleName = teacherRoleName };
            //Role adminRole = new Role { Id = Guid.NewGuid(), RoleName = adminRoleName };

            //UserRole super_admin = new UserRole { Id = Guid.NewGuid(), RoleId = superAdminRole.Id };
            //UserRole student = new UserRole { Id = Guid.NewGuid(), RoleId = studentRole.Id };
            //UserRole teacher = new UserRole { Id = Guid.NewGuid(), RoleId = teacherRole.Id };
            //UserRole admin = new UserRole { Id = Guid.NewGuid(), RoleId = adminRole.Id };

            //modelBuilder.Entity<Role>().HasData(new Role[] { superAdminRole, studentRole, teacherRole, adminRole });
            ////modelBuilder.Entity<UserRole>().HasData(new UserRole[] { admin, super_admin, student, teacher });

            ////create user
            //User adminUser = new User { Id = Guid.NewGuid(), Email = adminEmail, Password = adminPassword, ConfirmPassword = adminPassword };
            //modelBuilder.Entity<User>().HasData(new User[] { adminUser });


            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = Guid.NewGuid(), SpecialityName = "Физика" });
            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = Guid.NewGuid(), SpecialityName = "Химия" });
            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = Guid.NewGuid(), SpecialityName = "Алгебра" });
            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = Guid.NewGuid(), SpecialityName = "Биология" });

            //modelBuilder.Entity<Course>().HasData(new Course[] {1,2,3,4,5,6});
            //modelBuilder.Entity<UserRole>().HasData( new UserRole[] { studentRole, });

        }

        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> User { get; set; }
    }
}
