using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge039
	{
		public static string Description()
		{
			return "String/Loop Manipulation: Fizz-Buzz";
		}

		public void Challenge_039()
		{
			string fizz = "Fizz";
			string buzz = "Buzz";
			
			while(true)
			{
				Console.WriteLine("FizzBuzz up to target number.");
				try
				{
					int target = int.Parse(Console.ReadLine());

					for(int i = 1; i <= target; i++)
					{
						if(i % 3 == 0 && i % 5 == 0)
							Console.WriteLine(fizz + buzz);
						else if(i % 3 == 0)
							Console.WriteLine(fizz);
						else if(i % 5 == 0)
							Console.WriteLine(buzz);
						else
							Console.WriteLine(i);
					}
					Console.WriteLine("Play again? y/n");
					var playAgain = Console.ReadLine();
					if(playAgain.ToLower() == "n" || playAgain.ToLower() == "no")
						break;
				}
				catch(Exception)
				{
					Console.WriteLine("Not a number, try again!\n");
				}
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/s6bas/4122012_challenge_39_easy/");
		}
	}
}
