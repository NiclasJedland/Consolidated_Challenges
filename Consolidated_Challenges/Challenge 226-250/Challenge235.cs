using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge235
	{
		public static string Description()
		{
			return "Math Problem: Ruth-Aaron Pairs";
		}

		public void Challenge_235()
		{
			var breakpoints = new List<string>() { "n", "no", "exit", "stop", "quit" };
			var input = "";
			while(true)
			{
				Console.WriteLine("\nCheck if number is Ruth-Aaron Pairs.");
				input = Console.ReadLine();
				if(breakpoints.Contains(input.ToLower()))
					break;
				var num = int.Parse(input);
				if(FindFactors(num).Distinct().Sum() == FindFactors(num + 1).Distinct().Sum())
					Console.WriteLine("({0},{1}) VALID", num, num + 1);
				else
					Console.WriteLine("({0},{1}) INVALID", num, (num + 1));
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3nkanm/20151005_challenge_235_easy_ruthaaron_pairs/");
		}

		static List<long> FindFactors(long num)
		{
			var result = new List<long>();
			while(num % 2 == 0)
			{
				result.Add(2);
				num /= 2;
			}
			long factor = 3;
			while(factor * factor <= num)
			{
				if(num % factor == 0)
				{
					result.Add(factor);
					num /= factor;
				}
				else
					factor += 2;
			}
			if(num > 1)
				result.Add(num);
			return result;
		}
	}
}
