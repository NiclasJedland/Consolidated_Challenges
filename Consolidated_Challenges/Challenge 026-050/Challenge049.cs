using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge049
	{
		public static string Description()
		{
			return "Math Problem: Monty Hall Paradox";
		}

		public void Challenge_049()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			Console.WriteLine("Monty Hall Problem");

			NoChange();
			Change();

			sw.Stop();
			Console.WriteLine("\n\nTime(ms): " + sw.ElapsedMilliseconds);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/tb2h0/572012_challenge_49_easy/");
		}
		
		public static void NoChange()
		{
			Random rand = new Random();
			int winningDoor;
			int win = 0;
			int loss = 0;
			int pick = 0;

			for(int i = 0; i < 100000; i++)
			{
				winningDoor = rand.Next(0, 3);

				if(pick == winningDoor)
					win++;
				else
					loss++;
			}
			Console.WriteLine("No Change\nWins: " + win + "\nLoss: " + loss + "\nPercent: " + (float)win / 99999 * 100);
		}
		
		public static void Change()
		{
			Random rand = new Random();
			int winningDoor;
			int win = 0;
			int loss = 0;
			int pick = 0;

			for(int i = 0; i < 99999; i++)
			{
				winningDoor = rand.Next(0, 3);

				if(pick == winningDoor)
					loss++;
				else
					win++;
			}
			Console.WriteLine("\nChange\nWins: " + win + "\nLoss: " + loss + "\nPercent: " + (float)win / 99999 * 100);
		}
	}
}
