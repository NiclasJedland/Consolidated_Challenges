using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge029
	{
		public static string Description()
		{
			return "String Manipulation: Palindrome";
		}

		public void Challenge_029()
		{
			Palindrome("Hannah");
			Palindrome("1234321");
			Palindrome("123321");
			Palindrome("12345");
			Palindrome("han nah");
			Palindrome("Dammit I’m mad.");

			Console.WriteLine("Check your own string:");
			Palindrome(Console.ReadLine());
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/r8a70/3222012_challenge_29_easy/");
		}

		public static void Palindrome(string palindrome)
		{
			palindrome = palindrome.ToLower();

			palindrome = new string(palindrome.Where(c => char.IsLetterOrDigit(c)).ToArray());
			var reversed = palindrome.ToCharArray();

			Array.Reverse(reversed);
			if(palindrome == new string(reversed))
				Console.WriteLine("The string: " + palindrome + " IS a palindrome. \n");
			else
			{
				Console.WriteLine("Reversed string: " + new string(reversed));
				Console.WriteLine("The string: " + palindrome + " is NOT a palindrome. \n");
			}
		}
	}
}
