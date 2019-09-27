using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectText { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
