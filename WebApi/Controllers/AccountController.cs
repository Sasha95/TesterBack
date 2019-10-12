using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Domain;
using WebApi.Models.Users;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(ApplicationContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult<User>> Post(User model)//[FromBody]
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User user = await _userManager.FindByEmailAsync(model.Email);
                    if (user == null) return StatusCode(StatusCodes.Status401Unauthorized, "Incorrect email or password");

                    var passwordOk = await _userManager.CheckPasswordAsync(user, model.Password);

                    //if (!passwordOk) return StatusCode(StatusCodes.Status401Unauthorized, "Incorrect email or password");

                    //model.Id = user.Id;
                    //model.Email = user.Email;
                    //model.Password = "";

                    //int expiresIn;
                    //long expiresOn;
                    //model.Token

                    return Ok();
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            return BadRequest();

        }

    }
}