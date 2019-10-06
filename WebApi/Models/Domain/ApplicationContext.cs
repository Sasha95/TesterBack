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

            Role superAdminRole = new Role { Id = 1, Name = superAdmin };
            Role teacherRole = new Role { Id = 2, Name = teacherRoleName };
            Role studentRole = new Role { Id = 3, Name = studentRoleName };
            Role adminRole = new Role { Id = 4, Name = adminRoleName };

            modelBuilder.Entity<Role>().HasData(new Role[] { superAdminRole, studentRole, teacherRole, adminRole });

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
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }

        //набор таблиц для тестов
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestInfo> TestsInfo { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
    }
}
