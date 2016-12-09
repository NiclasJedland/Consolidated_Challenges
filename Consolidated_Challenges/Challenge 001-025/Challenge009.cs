using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge009
	{
		public static string Description()
		{
			return "List Manipulation: Sorting";
		}

		public void Challenge_009()
		{
			SortNumbers();

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pu1rf/2172012_challenge_9_easy/");
		}

		public static void SortNumbers()
		{
			int numberCount = 0;
			int count = 0;

			Console.WriteLine("Write n numbers and rearrange them in order.\nHow many numbers will you write?");
			count = Int32.Parse(Console.ReadLine());

			var input = new int[count];

			while(numberCount < count)
			{
				Console.Write("Number {0}? ", numberCount + 1);
				input[numberCount] = Int32.Parse(Console.ReadLine());

				numberCount++;
			}

			Console.WriteLine("\n");
			//show numbers before sort
			for(int i = 0; i < count; i++)
			{
				Console.WriteLine("Array element[{0}] is: {1} ", i, input[i]);
			}
			Console.WriteLine("\n");
			Array.Sort(input);

			//show numbers after sort
			for(int i = 0; i < count; i++)
			{
				Console.WriteLine("Array element[{0}] is: {1} ", i, input[i]);
			}
		}
	}
}
