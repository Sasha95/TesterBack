using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class TestInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AnswerId { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Answer Answer { get; set; }

        public Question Question { get; set; }
    }
}
