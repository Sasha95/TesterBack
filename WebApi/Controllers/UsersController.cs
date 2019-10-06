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
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.Users.ToListAsync();
        }


        // PUT: api/Users
        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            if (!_context.Users.Any(x => x.Id == user.Id))
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
            if (model == null)
            {
                ModelState.AddModelError("", "Не указаны данные для пользователя");
                return BadRequest(ModelState);
            }
            //проверяем существует ли в базе такое мыло
            if (_context.Users.Any(x => x.Email == model.Email))
            {
                ModelState.AddModelError("Email", "Такой пользователь уже существует!");
            }

            //если в ModelState нет ошибок то создаем пользователя
            if (ModelState.IsValid)
            {
                //надо создать таблицу ролей
                User user = new User { Email = model.Email };//UserName = model.Email 
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //await _signInManager.SignInAsync(user, false);
                    return Ok();
                }
                else return BadRequest(ModelState);
            }

            return BadRequest();

        }
    }
}
