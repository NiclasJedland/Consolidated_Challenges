using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge240
	{
		public static string Description()
		{
			return "String Manipulation: Typoglycemia";
		}

		public void Challenge_240()
		{
			string text = "According to a research team at Cambridge University, it doesn't matter in what order the letters in a word are, the only important thing is that the first and last letter be in the right place. The rest can be a total mess and you can still read it without a problem. This is because the human mind does not read every letter by itself, but the word as a whole. Such a condition is appropriately called Typoglycemia.";
			Console.WriteLine("Original Text: \nAccording to a research team at Cambridge University, it doesn't matter in what order the letters in a word are, the only important thing is that the first and last letter be in the right place. The rest can be a total mess and you can still read it without a problem. This is because the human mind does not read every letter by itself, but the word as a whole. Such a condition is appropriately called Typoglycemia.\n");
			Typoglycemia(text);
			Typoglycemia2(text);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3s4nyq/20151109_challenge_240_easy_typoglycemia/");
		}

		static void Typoglycemia(string text)
		{
			var rnd = new Random();
			string output = "";
			var splittedText = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
			foreach(var word in splittedText)
			{
				if(word.Length > 5)
				{
					string temp = "";
					string first = word.Substring(0, 2);
					string mid = word.Substring(2, word.Length - 4);
					string last = word.Substring(word.Length - 2, 2);
					output += first;
					output += new string(mid.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());
					output += last;
					output += temp;
				}
				else
					output += word;
				output += " ";
			}
			Console.WriteLine(output + "\n");
		}

		static void Typoglycemia2(string text)
		{
			var rnd = new Random();
			string output = "";
			var splittedText = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
			foreach(var word in splittedText)
			{
				if(word.Length > 3)
				{
					string temp = "";
					string first = word.Substring(0, 1);
					string mid = word.Substring(1, word.Length - 2);
					string last = word.Substring(word.Length - 1, 1);
					output += first;
					output += new string(mid.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());
					output += last;
					output += temp;
				}
				else
					output += word;
				output += " ";
			}
			Console.WriteLine(output);
		}
	}
}
