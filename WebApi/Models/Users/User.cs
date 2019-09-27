using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Users
{
<<<<<<< HEAD
    public class User : IdentityUser
    {
        //[Key]
        //public Guid Id { get; set; }

        //[Required]
        //[Display(Name = "Email")]
        //public string Email { get; set; }
=======
    public class User 
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
>>>>>>> 5f991939d27868d48c0aadf9e3ade27fa2069771

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

<<<<<<< HEAD
        //[Required]
        //[Compare("Password", ErrorMessage = "Пароли не совпадаю")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Подтвердить пароль")]
        //public string ConfirmPassword { get; set; }
=======
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадаю")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string ConfirmPassword { get; set; }
>>>>>>> 5f991939d27868d48c0aadf9e3ade27fa2069771

        //public int UserRoleId { get; set; }
        //public UserRole UserRole { get; set; }


    }
}
