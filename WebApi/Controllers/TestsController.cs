using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Domain;
using WebApi.Models.Tests;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestsController : ControllerBase
	{
		private readonly ApplicationContext _context;

		public TestsController(ApplicationContext context)
		{
			_context = context;
		}

		// GET: api/Tests
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Test>>> GetTests()
		{
			return await _context.Tests.ToListAsync();
		}

		// GET: api/Tests/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Test>> GetTest(int id)
		{
			var test = await _context.Tests.FindAsync(id);

			if (test == null)
			{
				return NotFound();
			}

			return test;
		}

		// PUT: api/Tests/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTest(int id, Test test)
		{
			if (id != test.Id)
			{
				return BadRequest();
			}

			_context.Entry(test).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!TestExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		//add test 
		[Route("AddTest")]
		public async Task<ActionResult<Test>> AddTest(Test test)
		{
			_context.Tests.Add(test);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetTest", new { id = test.Id }, test);
		}

		//add question 
		[Route("AddQuestion")]
		public async Task<ActionResult<Question>> AddQuestion(Question question)
		{
			_context.Questions.Add(question);
			await _context.SaveChangesAsync();

			return Ok();
		}

		//add answer
		[Route("AddAnswer")]
		public async Task<ActionResult<Answer>> AddAnswer(Answer answer)
		{
			_context.Answers.Add(answer);
			await _context.SaveChangesAsync();

			return Ok();
		}

		//add UserAnswer
		[Route("AddUserAnswer")]
		public async Task<ActionResult<UserAnswer>> AddUserAnswer(UserAnswer userAnswer)
		{
			_context.UserAnswers.Add(userAnswer);
			//_context.UserAnswer.Add(userAnswer);
			await _context.SaveChangesAsync();

			return Ok();
		}

		//decision true or false
		[Route("Decision")]
		public async Task<ActionResult> Decision( )
		{
			if (true)//у вопроса больше одного ответа
			{

			}
			else //если ответ единственно верный, а => это мат выражение, пропускаем через вольфрам ответы автора теста и студента
			{

			}
			return Ok();
		}


		

        //add topic
        [Route("AddTopic")]
        public async Task<ActionResult<Topic>> AddTopic(Topic topic)
        {
            _context.Topics.Add(topic);
            await _context.SaveChangesAsync();

            return Ok();
        }


        // DELETE: api/Tests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test>> DeleteTest(int id)
        {
            var test = await _context.Tests.FindAsync(id);
            if (test == null)
            {
                return NotFound();
            }

            _context.Tests.Remove(test);
            await _context.SaveChangesAsync();

            return test;
        }

        private bool TestExists(int id)
        {
            return _context.Tests.Any(e => e.Id == id);
        }
    }
}
