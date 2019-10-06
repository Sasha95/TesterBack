using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SubjectText { get; set; }

        [Required]
        public Branch Branch { get; set; }
    }
}
