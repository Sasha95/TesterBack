using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class UserAnswer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Question Question { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Answer Answer { get; set; }

        [Required]
        public int AnswerId { get; set; } // поле для хранения ссылки на один из вариантов предоставленных преподователем

        public Session Session { get; set; }

        [Required]
        public int SessionId { get; set; }
    }
}
