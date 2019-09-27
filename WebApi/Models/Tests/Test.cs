using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Test
    {
        public int Id { get; set; }
        public string TestText { get; set; }
        public int TopicId { get; set; }
        public int SummaryId { get; set; }
        public Topic Topic { get; set; }
        public Summary Summary { get; set; }

    }
}
