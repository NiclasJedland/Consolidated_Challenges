using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge017
	{
		public static string Description()
		{
			return "String Manipulation: Pyramid";
		}

		public void Challenge_017()
		{
			Console.WriteLine("Height of pyramid");

			DrawTriangle(25);
			Console.WriteLine();
			DrawReversedTriangle(25);
			Console.WriteLine();

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qheeu/342012_challenge_17_easy/");
		}

		public static void DrawTriangle(int height)
		{
			for(int i = 0; i < height; i += 2)
			{
				for(int k = i; k < height - 2; k++)
				{
					Console.Write(" ");
				}

				for(int j = 0; j <= i * 2; j++)
				{
					Console.Write("#");
				}
				Console.Write("\n");
			}
		}

		public static void DrawReversedTriangle(int height)
		{
			for(int i = height; i > 0; i -= 2)
			{
				for(int j = height - i + 0; j > 0; j--)
				{
					Console.Write(" ");
				}
				for(int j = 2 * i - 1; j > 2; j--)
				{
					Console.Write("#");
				}
				Console.Write("\n");
			}
		}
	}
}
