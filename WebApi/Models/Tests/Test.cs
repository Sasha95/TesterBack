using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Test
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TestText { get; set; }

        [Required]
        public Topic Topic { get; set; }

        [Required]
        public Summary Summary { get; set; }

    }
}
