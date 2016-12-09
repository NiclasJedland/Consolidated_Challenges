using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge014
	{
		public static string Description()
		{
			return "List Manipulation: Reverse Block of 3";
		}

		public void Challenge_014()
		{
			var lst = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
			int blocksize = 3;
			var output = new List<string>();			

			for(int i = 0; i < lst.Count; i += blocksize)
			{
				if(i + 2 < lst.Count)
					output.Add(lst[i + 2]);
				if(i + 1 < lst.Count)
					output.Add(lst[i + 1]);
				output.Add(lst[i]);
			}
			output.ForEach(x => { Console.WriteLine(x); });

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/q2v2k/2232012_challenge_14_easy/");
		}
	}
}
