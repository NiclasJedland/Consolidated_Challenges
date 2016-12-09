using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge033
	{
		public static string Description()
		{
			return "String/Dictionary Manipulation: Flash Cards";
		}

		public void Challenge_033()
		{
			var flashCard = new Dictionary<string, string>(){{"Hello", "Konnichiwa" }, {"Yes", "Hai" }, {"No", "Iie" }, {"10*10", "100" }};
			FlashCard(flashCard);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/rl24e/3302012_challenge_33_easy/");
		}
		
		public static void FlashCard(Dictionary<string, string> flashCard)
		{
			while(true)
			{
				Random rand = new Random();

				for(int i = 0; i < flashCard.Count; i++)
				{
					var item = flashCard.ElementAt(i);
					var itemKey = item.Key;
					var itemValue = item.Value;
				}

				int next = rand.Next(0, flashCard.Count);
				Console.WriteLine("What is on the other side of: " + flashCard.ElementAt(next).Value);

				string answer = Console.ReadLine();
				answer = answer.Replace(" ", "");

				if(answer.ToLower() == flashCard.ElementAt(next).Key.ToLower())
					Console.WriteLine("Correct. Play again?");
				else
					Console.WriteLine("Incorrect. Play again?");

				string playagain = Console.ReadLine();
				if(playagain.ToLower() == "n" || playagain.ToLower() == "no")
					break;
			}
		}
	}
}