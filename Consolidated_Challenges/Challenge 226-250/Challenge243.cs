using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge243
	{
		public static string Description()
		{
			return "Math Problem: Abundant And Deficient Numbers";
		}

		public void Challenge_243()
		{
			var input = new List<int>() { 111, 112, 220, 69, 134, 85 };

			foreach(var item in input)
				IsAbundant(item);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3uuhdk/20151130_challenge_243_easy_abundant_and/");
		}

		void IsAbundant(int num)
		{
			int sum = 0;

			for(int i = 1; i <= num; i++)
			{
				if(num % i == 0)
					sum += i;
			}

			if(num * 2 < sum)
				Console.WriteLine("{0} is abundant by {1}", num, sum - (num * 2));
			else if(num * 2 > sum)
				Console.WriteLine("{0} is deficient", num);
			else
				Console.WriteLine("{0} is neither", num);
		}
	}
}
