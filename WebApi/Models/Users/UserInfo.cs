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
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Required]
        public int SpecialityId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Speciality UserSpeciality { get; set; }

        [Required]
        public Course  Course { get; set; }

    }
}
