using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge231
	{
		public static string Description()
		{
			return "String Manipulation: Palindromes";
		}

		public void Challenge_231()
		{
			string test = "00000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000";
			Output(test);
			for(int i = 0; i < 25; i++)
			{
				string output = "";
				for(int j = 0; j < test.Length; j++)
					output += (int)((j > 0 ? test[j - 1] - 48 : 0) ^ (j < test.Length - 1 ? test[j + 1] - 48 : 0)) == 0 ? '0' : '1';
				Output(test = output);
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
			{
				Console.WriteLine("\n\nNOTE\nThis says 213, but it is actually 231");
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3jz8tt/20150907_challenge_213_easy_cellular_automata/");
			}

		}

		public static void Output(string s)
		{
			Console.WriteLine(s.Replace("0", " ").Replace("1", "X"));
		}
	}
}
