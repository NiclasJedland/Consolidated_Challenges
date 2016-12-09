using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge035
	{
		public static string Description()
		{
			return "String/List Manipulation: Trianglify";
		}

		public void Challenge_035()
		{
			Console.WriteLine("Number to trianglify.");
			int number = int.Parse(Console.ReadLine());
			var maxnumber = Math.Floor((-1 + Math.Sqrt(1 + 8 * number)) / 2);

			int TEMP = 0;
			int ROWS = 0, Y = 1;
			for(; Y <= number; Y++, Y += ROWS)
				ROWS++;

			Y -= ROWS + 1;
			TEMP = Y - (ROWS - 1);

			for(int UNT = TEMP; ROWS != 1; UNT++)
			{
				Console.Write(UNT + " ");
				if(UNT == Y)
				{
					Console.WriteLine();
					Y -= ROWS;
					TEMP = Y - ROWS;
					UNT = TEMP + 1;
					ROWS--;
				}
			}
			Console.WriteLine("1\n");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/rr4y2/432012_challenge_35_easy/");
		}
	}
}
