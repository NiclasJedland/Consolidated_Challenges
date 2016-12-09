using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge015
	{
		public static string Description()
		{
			return "String Manipulation: Trimming";
		}

		public void Challenge_015()
		{
			string test = "   this is a test   ";

			Console.WriteLine(test.Trim().PadLeft(50, ' '));
			Console.WriteLine(test.Trim());

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/q4c34/2242012_challenge_15_easy/");
		}
	}
}
