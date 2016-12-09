using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge228
	{
		public static string Description()
		{
			return "String Manipulation: Letters in Alphabetical Order";
		}

		public void Challenge_228()
		{
			var words = new List<string>() {"almost", "cereal", "billowy", "biopsy", "chinos", "defaced",
				"chintz", "sponged", "bijoux", "abhors", "fiddle", "begins", "chimps", "wronged" };
			foreach(var word in words)
				Console.WriteLine("{0} is {1}", word, FindOrder(word));

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3h9pde/20150817_challenge_228_easy_letters_in/");
		}

		static string FindOrder(string word)
		{
			if(word == new string(word.OrderBy(c => c).ToArray()))
				return "IS in order.";
			else if(word == new string(word.OrderByDescending(c => c).ToArray()))
				return "is in REVERSED order.";
			return "NOT in order.";
		}
	}
}
