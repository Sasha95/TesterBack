using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Tests
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TopicText { get; set; }

        [Required]
        public Subject Subject { get; set; }
    }
}
