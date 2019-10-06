using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Users
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
