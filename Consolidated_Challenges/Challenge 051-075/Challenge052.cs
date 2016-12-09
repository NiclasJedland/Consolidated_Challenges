using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge052
	{
		public static string Description()
		{
			return "String Manipulation: Word Value";
		}

		public void Challenge_052()
		{
			var lst = new List<string>() { "hat", "Shoe", "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z", "ABCDEFGHIJKLMNOPQRSTUVWXYZ" };

			var dict = StringSum(lst);
			dict.ToList().ForEach(x => { Console.WriteLine(x.Key + ":" + x.Value); });

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/tmnfq/5142012_challenge_52_easy/");
		}

		public static Dictionary<string, int> StringSum(List<string> words)
		{
			var output = new Dictionary<string, int>();
			foreach(var word in words)
			{
				var sumOfWord = word.ToLower().Where(c => char.IsLetter(c)).Select(c => { return (int)(c - 96); }).Sum();
				output.Add(word, sumOfWord);
			}
			return output.OrderBy(s => s.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
		}
	}
}