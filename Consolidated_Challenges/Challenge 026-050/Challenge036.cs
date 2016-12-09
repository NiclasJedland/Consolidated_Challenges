using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge036
	{
		public static string Description()
		{
			return "Math Problem: Lockers";
		}

		public void Challenge_036()
		{
			var lockers = new bool[1001];

			for(int i = 1; i < 1001; i++)
			{
				for(int j = i; j < 1001; j += i)
					lockers[j] = !lockers[j];
			}

			int openLockers = 0;

			for(int i = 1; i < 1001; i++)
			{
				if(lockers[i])
				{
					Console.WriteLine("Open lockers: " + i);
					openLockers++;
				}
			}
			Console.WriteLine("# of open lockers: " + openLockers);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/ruiob/452012_challenge_36_easy/");
		}
	}
}
