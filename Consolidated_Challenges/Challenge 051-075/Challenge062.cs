using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge062
	{
		public static string Description()
		{
			return "Math Problem: Ullmans Puzzle";
		}

		public void Challenge_062()
		{
			while(true)
			{
				Random rnd = new Random();
				var numbers = new List<float>() {18.1f, 55.1f, 91.2f, 74.6f, 73.0f, 85.9f, 73.9f, 81.4f, 87.1f, 49.3f, 88.8f, 5.7f,
														26.3f, 7.1f, 58.2f, 31.7f, 5.8f, 76.9f, 16.5f, 8.1f, 48.3f, 6.8f, 92.4f, 83.0f, 19.6f};
				int k = 3;
				float t = 98.2f;

				float total = 0;
				float sum = 0;

				for(int i = 0; i < k; i++)
				{
					sum = numbers[rnd.Next(0, 24)];
					total += sum;
					Console.WriteLine(sum);
				}

				if(total < t)
					Console.WriteLine("\n" + total + "\nYou.. win?\nPlay again?y/n");
				else
					Console.WriteLine(total + "\nPlay again?y/n");

				string playagain = Console.ReadLine();
				if(playagain == "n" || playagain == "no")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/urqcx/682012_challenge_62_easy/");
		}
	}
}
