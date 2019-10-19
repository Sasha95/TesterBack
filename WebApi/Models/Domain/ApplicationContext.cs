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

            Role superAdminRole = new Role { Id = 1, Name = "super_admin" };
            Role teacherRole = new Role { Id = 2, Name = "teacher" };
            Role studentRole = new Role { Id = 3, Name = "student" };
            Role adminRole = new Role { Id = 4, Name = "admin" };

            modelBuilder.Entity<Role>().HasData(new Role[] { superAdminRole, studentRole, teacherRole, adminRole });

            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 1, SpecialityName = "Физика" });
            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 2, SpecialityName = "Химия" });
            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 3, SpecialityName = "Алгебра" });
            //modelBuilder.Entity<Speciality>().HasData(new Speciality() { Id = 4, SpecialityName = "Биология" });

            for (int i = 1; i < 7; i++)
            {
                modelBuilder.Entity<Course>().HasData(new Course() { Id = i, CorseNumber = i });
            }

            /*create initial data for tests*/
            
            //add branch data to table
            Branch chemistry = new Branch() { Id = 1, BranchText = "Химия" };
            Branch history = new Branch() { Id = 2, BranchText = "История" };
            Branch physics = new Branch() { Id = 3, BranchText = "Физика" };
            Branch literatura = new Branch() { Id = 4, BranchText = "Литература" };

            modelBuilder.Entity<Branch>().HasData(new Branch[] { chemistry, history, physics, literatura });

            //add subject data to table
            modelBuilder.Entity<Subject>().HasData(new Subject() { Id = 1, SubjectText = "Русская литература", BranchId = literatura.Id });

            //add topic to table
            modelBuilder.Entity<Topic>().HasData(new Topic() { Id = 1, TopicText = "Поэты 18 века", SubjectId = 1 });

            //add question to table
            modelBuilder.Entity<Question>().HasData(new Question() { Id = 1, QuestionText = "Год рождения Пушкина А.С." });

            //add answers to table
            modelBuilder.Entity<Answer>().HasData(new Answer() { Id = 1, AnswerText = "1799", Realy = true });
            modelBuilder.Entity<Answer>().HasData(new Answer() { Id = 2, AnswerText = "1789", Realy = false });
            modelBuilder.Entity<Answer>().HasData(new Answer() { Id = 3, AnswerText = "1899", Realy = false });
            modelBuilder.Entity<Answer>().HasData(new Answer() { Id = 4, AnswerText = "1801", Realy = false });

            //add data to summary table
            modelBuilder.Entity<Summary>().HasData(new Summary() { Id = 1, QuestionId = 1, AnswerId = 1 });
            modelBuilder.Entity<Summary>().HasData(new Summary() { Id = 2, QuestionId = 1, AnswerId = 2 });
            modelBuilder.Entity<Summary>().HasData(new Summary() { Id = 3, QuestionId = 1, AnswerId = 3 });
            modelBuilder.Entity<Summary>().HasData(new Summary() { Id = 4, QuestionId = 1, AnswerId = 4 });

			modelBuilder.Entity<Session>().HasData(new Session() {Id =1, Test = null });

			//add answer to UsweAnswer table
			modelBuilder.Entity<UserAnswer>().HasData(new UserAnswer() { Id = 1, QuestionId = 1, SessionId = 1, AnswerId = 1});

        }

        //набор таблиц для управления пользователями
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Role> Roles { get; set; }

        //набор таблиц для тестов
        public DbSet<Test> Tests { get; set; }
        //public DbSet<TestInfo> TestsInfo { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Summary> Summaries { get; set; }
    }
}
