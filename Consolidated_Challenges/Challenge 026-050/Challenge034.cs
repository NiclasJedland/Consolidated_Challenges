using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge034
	{
		public static string Description()
		{
			return "Math/List: 2 Highest Numbers Squared";
		}

		public void Challenge_034()
		{
			while(true)
			{
				string numberString = "";

				Console.WriteLine("Write 3 numbers, use space between them");
				numberString = Console.ReadLine();
				string[] numberStrings = numberString.Split(' ');

				if(numberStrings.Length == 3)
				{
					int[] numbers = new int[3];

					for(int i = 0; i < 3; i++)
					{
						numbers[i] = int.Parse(numberStrings[i]);
					}

					Array.Sort(numbers);

					Console.WriteLine(numbers[1] + "^2 + " + numbers[2] + "^2 = " + (numbers[1] * numbers[1] + numbers[2] * numbers[2]) + "\nPlay Again?");
					string playagain = Console.ReadLine();
					if(playagain.ToLower() == "n" || playagain.ToLower() == "no")
						break;
				}
				else
					Console.WriteLine("Too many or too few numbers!");
			}
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/rmmn8/3312012_challenge_34_easy/");
		}
	}
}
