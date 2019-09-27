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
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public User User { get; set; }
        
    }
}
