using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge008
	{
		public static string Description()
		{
			return "Loops: For-loop";
		}
		public void Challenge_008()
		{
			for(int i = 99; i > 0; i--)
			{
				Console.WriteLine(i + " bottles of beer on the wall. " + i + " bottles of beer. Take one down and pass it around, " + (i - 1) + " bottles of beer on the wall.");
			}
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pserp/2162012_challenge_8_easy/");
		}
	}
}
