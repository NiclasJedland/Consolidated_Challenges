using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge056
	{
		public static string Description()
		{
			return "String Manipulation: Unavoidable Pattern: Zimin Words";
		}

		public void Challenge_056()
		{
			//char[] array = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			char[] array = new char[] { 'a', 'b', 'c', 'd', 'e', 'f'};
			string fullString = "";

			for(int i = 0; i < array.Length; i++)
				fullString = fullString + array[i] + fullString;

			Console.WriteLine(fullString);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/u0tdt/5232012_challenge_56_easy/");
		}
	}
}
