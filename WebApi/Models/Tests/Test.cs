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

        public Topic Topic { get; set; }

        public Summary Summary { get; set; }

    }
}
