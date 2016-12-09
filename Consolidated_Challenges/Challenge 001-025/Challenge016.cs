using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge016
	{
		public static string Description()
		{
			return "String Manipulation: Remove Letters";
		}

		public void Challenge_016()
		{
			Console.WriteLine("Write a string");
			string original = Console.ReadLine();
			Console.WriteLine("Which letters to remove");
			string remove = Console.ReadLine();

			foreach(var s in remove)
			{
				original = original.Replace(s.ToString(), "");
			}

			Console.WriteLine(original);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/q8aom/2272012_challenge_16_easy/");
		}
	}
}
