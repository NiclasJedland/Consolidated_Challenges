using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge046
	{
		public static string Description()
		{
			return "Math/String Manipulation: Number -> Bit -> Number";
		}

		public void Challenge_046()
		{
			while(true)
			{
				Console.WriteLine("Write number");
				int number = 0;
				string input = Console.ReadLine();
				if(int.TryParse(input, out number))
				{
					string binary = Convert.ToString(number, 2);
					Console.WriteLine((binary.Split('1').Length - 1).ToString());
				}

				string playAgain = Console.ReadLine();
				if(playAgain.ToLower() == "n" || playAgain.ToLower() == "no")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/szz5y/4302012_challenge_46_easy/");
		}
	}
}
