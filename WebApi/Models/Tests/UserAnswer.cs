using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int SessionId { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
        public Session Session { get; set; }
    }
}
