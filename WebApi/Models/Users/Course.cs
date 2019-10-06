using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Users
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CorseNumber { get; set; }
    }
}
