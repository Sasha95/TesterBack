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

        public Question Question { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Answer Answer { get; set; }

        [Required]
        public int AnswerId { get; set; }

        public Session Session { get; set; }

        [Required]
        public int SessionId { get; set; }
    }
}
