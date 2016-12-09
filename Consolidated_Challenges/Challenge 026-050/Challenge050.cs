using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge050
	{
		public static string Description()
		{
			return "Math Problem: Store Credits";
		}

		public void Challenge_050()
		{
			int[] array1 = { 5, 75, 25 };
			int[] array2 = { 150, 24, 79, 50, 88, 345, 3 };
			int[] array3 = { 2, 1, 9, 4, 4, 56, 90, 3 };
			Spend(100, array1);
			Spend(200, array2);
			Spend(8, array3);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/teua8/592012_challenge_50_easy/");
		}

		static void Spend(int credit, int[] items)
		{
			for(int i = 0; i < items.Length; i++)
			{
				for(int j = i + 1; j < items.Length; j++)
				{
					if(items[i] + items[j] == credit)
					{
						Console.WriteLine("Item #" + i + "(" + items[i] + ")" + " and " + j + "(" + items[j] + ")\n");
					}
				}
			}
		}
	}
}
