using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge060
	{
		public static string Description()
		{
			return "Math Problem: Polite Numbers";
		}

		public void Challenge_060()
		{
			while(true)
			{
				Console.WriteLine("Which number to check if polite?");
				try
				{
					int polite = int.Parse(Console.ReadLine());
					if(IsPolite(polite))
						Console.WriteLine(polite + " is polite.");
					else
						Console.WriteLine(polite + " is NOT polite.");
				}
				catch(Exception)
				{
					Console.WriteLine("Not a number");
				}

				Console.WriteLine("Try again?");
				var again = Console.ReadLine();
				if(again.ToLower() == "n" || again.ToLower() == "no")
					break;
			}
			
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/ukj56/642012_challenge_60_easy/");
		}

		static bool IsPolite(int number)
		{
			if(number < 0)
				return false;
			if((Math.Log(number, 2) % 1) == 0)
				return false;
			return true;
		}
	}
}
