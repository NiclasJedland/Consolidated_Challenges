using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge218
	{
		public static string Description()
		{
			return "Math Problem: Making Numbers Palindromic";
		}

		public void Challenge_218()
		{
			var lst = new List<decimal>() { 11, 68, 123, 286, 196196871 };
			foreach(var s in lst)
				MakePalindrome(s);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/38yy9s/20150608_challenge_218_easy_making_numbers/");
		}

		static void MakePalindrome(decimal input)
		{
			decimal steps = 0;
			decimal placeholder = input;
			while(placeholder.ToString() != ReverseString(placeholder.ToString()))
			{
				steps++;
				placeholder = placeholder + decimal.Parse(ReverseString(placeholder.ToString()));
			}
			Console.WriteLine("{0} is a palindrome after {1} steps ({2})", input, steps, placeholder);
		}

		static string ReverseString(string s)
		{
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}