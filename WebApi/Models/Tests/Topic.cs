using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Topic
    {
        public int Id { get; set; }
        public string TopicText { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
