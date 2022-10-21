using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.DisaSoni.Controllers
{
    public class J2Controller : ApiController
    {
		/// <summary>
		/// Find the number of ways to determines how many ways we can roll the value of 10.
		/// </summary>
		/// <param name = "m">Positive integer representing the number of sides on the first die</param>
		/// <param name = "n">Positive integer representing the number of sides on the second die</param>
		/// <return>Outputs the number of ways we can roll the output of 10</return>
		/// GET api/J2/DiceGame/8/6 -> "There are 5 total ways to get the sum 10."
		[Route("api/J2/DiceGame/{m}/{n}")]
		[HttpGet]
		public string DiceGame(int m, int n)
		{
			int ans = 0;
			for (int i = 1; i < n + 1; i++)
			{
				for (int j = 1; j < m + 1; j++)
				{
					if (i + j == 10)
					{
						ans += 1;
						break;
					}
				}
			}
			string res = "There are " + ans + "  total ways to get the sum 10.";

			return res;
		}
	}
}
