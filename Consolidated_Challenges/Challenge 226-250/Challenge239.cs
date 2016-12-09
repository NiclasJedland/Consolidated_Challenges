using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge239
	{
		public static string Description()
		{
			return "Math Problem: Game of Threes";
		}

		public void Challenge_239()
		{
			var num = 0;
			while(true)
			{
				Console.WriteLine("Insert a number");
				var input = Console.ReadLine();
				if(int.TryParse(input, out num))
					break;
			}
			GameOfThrees(num);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3rhzdj/20151104_challenge_239_intermediate_a_zerosum/");
		}

		static void GameOfThrees(int num)
		{
			while(num != 1)
			{
				if(num % 3 == 0)
					Console.WriteLine(num + " 0");
				else if((num + 1) % 3 == 0)
				{
					Console.WriteLine(num + " 1");
					num++;
				}
				else if((num - 1) % 3 == 0)
				{
					Console.WriteLine(num + " -1");
					num--;
				}
				num /= 3;
			}
			Console.WriteLine(1);
		}
	}
}
