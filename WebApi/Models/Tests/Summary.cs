using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Summary
    {
        public int Id { get; set; }
        public Answer Answer { get; set; }
        public Question Question { get; set; }
    }
}
