using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge037
	{
		public static string Description()
		{
			return "String Manipulation: Count Words, Lines And Characters in a File";
		}

		public void Challenge_037()
		{
			int wordsCount = 0;
			int charactersCount = 0;

			Console.WriteLine("Counting. Please wait.\n");

			var content = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge037.txt");
						
			foreach(var word in content)
			{
				wordsCount += word.Trim().Split(' ').Count();
				foreach(var character in word)
				{
					charactersCount++;
				}
			}

			Console.WriteLine("Number of characters: " + charactersCount);
			Console.WriteLine("Number of words: " + wordsCount);
			Console.WriteLine("Number of lines: " + content.Count());

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/rzdwq/482012_challenge_37_easy/");
		}
	}
}
