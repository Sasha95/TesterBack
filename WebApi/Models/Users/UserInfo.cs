using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Users
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int SpecialityId { get; set; }

        public int CourseId { get; set; }

        [Required]
        public User User { get; set; }

        public Speciality UserSpeciality { get; set; }

        public Course  Course { get; set; }

    }
}
