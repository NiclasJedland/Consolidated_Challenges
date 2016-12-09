using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge018
	{
		public static string Description()
		{
			return "String Manipulation: Phone Numbers";
		}

		public void Challenge_018()
		{
			int test = 0;
			Console.WriteLine("Write the phonenumber to convert e.g. 1-800-COMCAST");

			string numbers = "1-800-COMCAST";

			Dictionary<char, int> dic = new Dictionary<char, int>()
			{   {'A', 2}, {'B', 2}, {'C', 2}, {'D', 3}, {'E', 3}, {'F', 3}, {'G', 4}, {'H', 4}, {'I', 4},
				{'J', 5}, {'K', 5}, {'L', 5}, {'M', 6}, {'N', 6}, {'O', 6}, {'P', 7}, {'Q', 7}, {'R', 7},
				{'S', 7}, {'T', 8}, {'U', 8}, {'V', 8}, {'W', 9}, {'X', 9}, {'Y', 9}, {'Z', 9}  };

			foreach(var number in numbers)
			{
				if(test == 3)
				{
					test = 0;
					Console.Write("-");
				}
				if(number == '-' || number == ' ' || number == '/')
					Console.Write("");
				else if(IsNumeric(number.ToString()) == true)
				{
					test++;
					Console.Write(number);
				}
				else
				{
					test++;
					Console.Write(dic[number]);
				}
			}
			Console.WriteLine("\nWish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qit0h/352012_challenge_18_easy/");
		}

		public static bool IsNumeric(string text)
		{
			int value = 0;
			if(int.TryParse(text, out value))
				return true;
			else
				return false;
		}

	}
}
