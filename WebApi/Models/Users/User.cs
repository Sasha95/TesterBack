using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Users
{
	public class User : IdentityUser
	{	[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		[Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        public Role Role { get; set; }

    }
}
