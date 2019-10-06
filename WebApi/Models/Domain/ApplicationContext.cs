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

            string adminRoleName = "admin";
            string studentRoleName = "student";
            string superAdmin = "super_admin";
            string teacherRoleName = "teacher";

            Role superAdminRole = new Role { Id = 1, RoleName = superAdmin };
            Role teacherRole = new Role { Id = 2, RoleName = teacherRoleName };
            Role studentRole = new Role { Id = 3, RoleName = studentRoleName };
            Role adminRole = new Role { Id = 4, RoleName = adminRoleName };

            UserRole super_admin = new UserRole { Id = 1, RoleId = superAdminRole.Id };
            UserRole student = new UserRole { Id = 2, RoleId = studentRole.Id };
            UserRole teacher = new UserRole { Id = 3, RoleId = teacherRole.Id };
            UserRole admin = new UserRole { Id = 4, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { superAdminRole, studentRole, teacherRole, adminRole });
            modelBuilder.Entity<UserRole>().HasData(new UserRole[] { admin, super_admin, student, teacher });

            modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 1, SpecialityName = "Физика" });
            modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 2, SpecialityName = "Химия" });
            modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 3, SpecialityName = "Алгебра" });
            modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 4, SpecialityName = "Биология" });

            for (int i = 1; i < 7; i++)
            {
                modelBuilder.Entity<Course>().HasData(new Course() { Id = i, CorseNumber = i });
            }

        }

        //набор таблиц для управления пользователями
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<Speciality> Specialities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }


        //набор таблиц для тестов
        //public DbSet<Answer> Answers { get; set; }
        //public DbSet<Branch> Branches { get; set; }
        //public DbSet<Question> Questions { get; set; }
        //public DbSet<Session> Sessions { get; set; }
        //public DbSet<Subject> Subjects { get; set; }
        //public DbSet<Summary> Summaries { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestInfo> TestsInfo { get; set; }
        //public DbSet<Topic> Topics { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
    }
}
