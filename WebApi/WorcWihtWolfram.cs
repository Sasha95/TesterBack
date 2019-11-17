using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wolfram.NETLink;

namespace WebApi
{
	public class WorcWihtWolfram
	{
		MathKernel mathKernel = new MathKernel();
		public string SimplifyExpression(string expression)
		{
			mathKernel.Compute("Simplify[" + expression + "]");
			return mathKernel.Result.ToString();
		}
	}
}
