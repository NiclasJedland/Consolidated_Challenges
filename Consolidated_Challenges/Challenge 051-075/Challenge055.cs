using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge055
	{
		public static string Description()
		{
			return "String Manipulation: Sliding Window Minimum Problem";
		}

		public void Challenge_055()
		{
			var lst = new List<int>() { 4, 3, 2, 1, 5, 7 };
			var lst2 = new List<int>();
			int mini = 3;
			int i = 0;
			while(i + 2 < lst.Count)
			{
				foreach(var s in lst.GetRange(i, mini))
					Console.Write(s);
				int min = lst.GetRange(i, mini).Min();
				Console.WriteLine();
				lst2.Add(min);
				i++;
			}
			foreach(var s in lst2)
				Console.Write(s);
			Console.WriteLine();

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/txla7/5212012_challenge_55_easy/");
		}
	}
}
