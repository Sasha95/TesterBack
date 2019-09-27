using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Domain;
using WebApi.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UsersController(ApplicationContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;


            //if (!_context.User.Any())
            //{
            //    _context.User.Add(new User { Email = "admin@mail.ru", Password = "123" });
            //    _context.SaveChangesAsync();
            //}
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }


        // GET: api/Users/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<User>> GetUser(Guid id)
        //{
        //    var user = await _context.User.FirstOrDefaultAsync(x => x.Id == id);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return new ObjectResult(user);
        //}

        // PUT: api/Users
        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            if (!_context.User.Any(x => x.Id == user.Id))
            {
                return NotFound();
            }

            _context.Update(user);
            _context.SaveChangesAsync();
            return Ok(user);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]User model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //await _signInManager.SignInAsync(user, false);
                    return Ok();
                }
                else return BadRequest();
            }

            return BadRequest();

        }

        //// DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(Guid id)
        //{
        //    User user = _context.User.FirstOrDefault(x => x.Id == id);

        //    if (user == null)
        //    {
        //        return BadRequest();
        //    }

        //    _context.User.Remove(user);
        //    _context.SaveChangesAsync();
        //    return Ok(user);
        //}

        //private bool UserExists(Guid id)
        //{
        //    return _context.User.Any(e => e.Id == id);
        //}
    }
}
