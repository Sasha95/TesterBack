using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Summary
    {
        [Key]
        public int Id { get; set; }

        public Answer Answer { get; set; }

        public int AnswerId { get; set; }

        public Question Question { get; set; }

        public int QuestionId { get; set; }
    }
}
