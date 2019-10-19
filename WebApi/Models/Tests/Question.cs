using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Tests;

namespace WebApi.Models.Tests
{
	public class Question
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string QuestionText { get; set; }

		[Required]
		public List<Answer> Answers{get; set;}

		public Answer Answer { get; set; }
    }
}
