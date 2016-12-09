using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge236
	{
		public static string Description()
		{
			return "Math Problem: Random Bag System";
		}
		
		public void Challenge_236()
		{
			var bag = Refill();
			int times = 3;
			while(true)
			{
				if(bag.Length == 0)
				{
					bag = Refill();
					Console.WriteLine();
					times--;
					if(times == 0)
						break;
				}
				Console.Write(bag[0]);
				bag = bag.Substring(1);
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3ofsyb/20151012_challenge_236_easy_random_bag_system/");
		}

		static Random rnd = new Random();
		static string Refill()
		{
			string output = "";			
			string letters = "OISZLJT";
			for(int i = 0; i < 50; i++)
				output += letters[rnd.Next(letters.Length)];
			return output;
		}
	}
}
