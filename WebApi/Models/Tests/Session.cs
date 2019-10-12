using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Users;

namespace WebApi.Models.Tests
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        public Test Test { get; set; }
    }
}
