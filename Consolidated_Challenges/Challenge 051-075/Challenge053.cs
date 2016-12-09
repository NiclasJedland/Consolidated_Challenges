using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge053
	{
		public static string Description()
		{
			return "List Manipulation: Merging And Sorting";
		}

		public void Challenge_053()
		{
			List<int> list1 = new List<int>() { 1, 5, 7, 8 };
			List<int> list2 = new List<int>() { 2, 3, 4, 7, 9 };
			List<int> list = new List<int>();

			list.AddRange(list1);
			list.AddRange(list2);
			list.Sort();

			list.ForEach(Console.WriteLine);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/tpxq9/5162012_challenge_53_easy/");
		}
	}
}
