using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Users;

namespace WebApi.Models.Tests
{
    public class Session
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		       
        public User User { get; set; }

		[Required]
		public int UserId { get; set; }

		public Test Test { get; set; }
    }
}
