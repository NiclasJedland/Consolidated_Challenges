using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge238
	{
		public static string Description()
		{
			return "String Manipulation: Random Words";
		}

		public void Challenge_238()
		{
			while(true)
			{
				Console.WriteLine("Randomize a word: Use only c for consonants and v for vocals (IE ccvcv)");
				var input = Console.ReadLine();
				while(!input.All(s => (char.ToLowerInvariant(s) == 'c') || char.ToLowerInvariant(s) == 'v'))
				{
					Console.WriteLine("Only use letters 'c' and 'v'!");
					input = Console.ReadLine();
				}
				Console.WriteLine(RandomWord(input));

				Console.WriteLine("Randomize another word?");
				var again = Console.ReadLine();
				if(again == "no" || again == "n")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3q9vpn/20151026_challenge_238_easy_consonants_and_vowels/");
		}

		static Random rnd = new Random();
		static string RandomWord(string input)
		{
			var consonants = "bcdfghjklmnpqrstvwxz".ToArray();
			var vowels = "aeiouy".ToArray();
			string output = "";

			foreach(var letter in input)
			{
				if(char.ToLower(letter) == 'c')
				{
					output += letter == 'c' ?
						consonants[rnd.Next(consonants.Length)].ToString() :
						consonants[rnd.Next(consonants.Length)].ToString().ToUpper();
				}
				else if(char.ToLower(letter) == 'v')
				{
					output += letter == 'v' ?
						vowels[rnd.Next(vowels.Length)].ToString() :
						vowels[rnd.Next(vowels.Length)].ToString().ToUpper();
				}
			}
			return output;
		}
	}
}
