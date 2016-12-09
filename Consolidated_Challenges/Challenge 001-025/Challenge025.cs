using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge025
	{
		public static string Description()
		{
			return "Math Problem: Calculate Majority";
		}

		public void Challenge_025()
		{
			Console.WriteLine("How many candidates?");
			int numberOfCandidates = Int32.Parse(Console.ReadLine());
			var votes = new int[numberOfCandidates];

			var candidates = new Dictionary<string, int>();

			for(int i = 1; i <= numberOfCandidates; i++)
			{
				Console.WriteLine("How many votes for candidate {0}?", i);
				candidates.Add("Candidate #" + i, Int32.Parse(Console.ReadLine()));
			}
			CountVotes(candidates, numberOfCandidates);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qxuug/3152012_challenge_25_easy/");
		}

		public static void CountVotes(Dictionary<string, int> votes, int numberOfCandidates)
		{
			var sortedDict = from entry in votes orderby entry.Value ascending select entry;

			Console.WriteLine(sortedDict.Sum(x => x.Value) - sortedDict.Last().Value);
			Console.WriteLine(sortedDict.Last().Value);

			foreach(KeyValuePair<string, int> author in sortedDict)
			{
				Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
			}

			if(sortedDict.Sum(v => v.Value) - sortedDict.Last().Value < sortedDict.Last().Value)
				Console.WriteLine("Majority goes to: " + sortedDict.Last().Key + " with " + sortedDict.Last().Value + " votes.");
			else
				Console.WriteLine("There is no majority!");
		}
	}
}
