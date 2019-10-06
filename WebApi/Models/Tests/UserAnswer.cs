using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class UserAnswer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Question Question { get; set; }

        [Required]
        public Answer Answer { get; set; }

        [Required]
        public Session Session { get; set; }
    }
}
