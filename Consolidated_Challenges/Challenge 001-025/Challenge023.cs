using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge023
	{
		public static string Description()
		{
			return "List Manipulation: Split List";
		}

		public void Challenge_023()
		{
			List<string> stringToSplit = new List<string>() { "test 1", "test 2", "test 3", "test 4", "test 5", "middle one" };
			stringToSplit.Add("1st string");
			stringToSplit.Add("2nd string");
			stringToSplit.Add("3rd string");
			stringToSplit.Add("4th string");
			stringToSplit.Add("5th string");

			SplitList(stringToSplit);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/quli5/3132012_challenge_23_easy/");
		}

		public static void SplitList(List<string> toSplit)
		{
			int listLength = toSplit.Count;

			List<string> firstHalf = new List<string>();
			List<string> secondHalf = new List<string>();
			List<string> middle = new List<string>();

			for(int i = 0; i < listLength; i++)
			{
				if(i < listLength / 2)
					firstHalf.Add(toSplit[i]);
				else if(i == listLength / 2)
					middle.Add(toSplit[i]);
				else
					secondHalf.Add(toSplit[i]);
			}

			for(int i = 0; i < firstHalf.Count; i++)
				Console.WriteLine("First set: " + firstHalf[i]);
			for(int i = 0; i < middle.Count; i++)
				Console.WriteLine("Middle one: " + middle[i]);
			for(int i = 0; i < secondHalf.Count; i++)
				Console.WriteLine("Second set: " + secondHalf[i]);

		}
	}
}
