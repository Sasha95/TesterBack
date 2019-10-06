using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Users
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        //public int UserId { get; set; }
        public int SpecialityId { get; set; }
        public int CourseId { get; set; }
        public User User { get; set; }
        public Speciality UserSpeciality { get; set; }
        public Course  Course { get; set; }

    }
}
