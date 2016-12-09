using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge010
	{
		public static string Description()
		{
			return "String Manipulation: Telephone Number Validation";
		}

		public void Challenge_010()
		{
			Console.WriteLine("Check if a telephone number is valid:");

			string number = Console.ReadLine();
			StringBuilder b = new StringBuilder(number);

			b.Replace("x", "A");
			b.Replace("1", "x");
			b.Replace("2", "x");
			b.Replace("3", "x");
			b.Replace("4", "x");
			b.Replace("5", "x");
			b.Replace("6", "x");
			b.Replace("7", "x");
			b.Replace("8", "x");
			b.Replace("9", "x");
			b.Replace("0", "x");
			
			string result = b.ToString();

			var validLst = new List<string>() { "xxxxxxxxxx", "xxx-xxx-xxxx", "xxx.xxx.xxxx", "(xxx)xxx-xxxx", "(xxx) xxx-xxxx",
												"xxx-xxxx", "(xxx) xxx.xxxx", "(xxx)xxx.xxxx", "xxx.xxxx", "xxx xxxx", "xxx xxx xxxx"};
			if(validLst.Contains(result))
				Console.WriteLine("Valid number");
			else
				Console.WriteLine("Invalid number");
			
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pv98f/2182012_challenge_10_easy/");
		}
	}
}
