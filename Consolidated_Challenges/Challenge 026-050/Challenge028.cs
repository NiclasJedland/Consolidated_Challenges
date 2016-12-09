using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge028
	{
		public static string Description()
		{
			return "List Manipulation: Find Duplicates";
		}

		public void Challenge_028()
		{
			int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 3, 9, 10, 2, 9, 3 };
			CheckDuplicates(intArray);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/r59kk/3202012_challenge_28_easy/");
		}

		public static void CheckDuplicates(int[] intArray)
		{
			for(int i = 0; i < intArray.Length; i++)
			{
				for(int j = i + 1; j < intArray.Length; j++)
				{
					if(intArray[i] == intArray[j])
						Console.WriteLine("Duplicates exist at array index: " + i + " and " + j + ". And the number is: " + intArray[i]);
				}
			}
		}
	}
}
