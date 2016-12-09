using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge057
	{
		public static string Description()
		{
			return "List Manipulation: Highest 3 Number Sequence of an Int Array";
		}

		public void Challenge_057()
		{
			int[] sequence = new int[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 };
			int max = 0;
			int[] highest = new int[3];

			for(int i = 0; i < sequence.Length; i++)
			{
				int sum = 0;
				int num1 = 0;
				int num2 = 0;
				int num3 = 0;

				if(i < sequence.Length - 2)
				{
					num1 = sequence[i + 0];
					num2 = sequence[i + 1];
					num3 = sequence[i + 2];
					sum = num1 + num2 + num3;
				}

				if(sum > max)
				{
					max = sum;
					highest[0] = num1;
					highest[1] = num2;
					highest[2] = num3;
				}
			}

			Console.WriteLine("Sum: " + max + " from " + highest[0] + " " + highest[1] + " " + highest[2]);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/u4mk4/5252012_challenge_57_easy/");
		}
	}
}
