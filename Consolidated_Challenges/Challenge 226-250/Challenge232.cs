using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge232
	{
		public static string Description()
		{
			return "String Manipulation: Palindromes";
		}

		public void Challenge_232()
		{
			var files = new List<List<string>>();
			files.Add(File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge232_1.txt").ToList());
			files.Add(File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge232_2.txt").ToList());
			files.Add(File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge232_3.txt").ToList());
			files.Add(File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge232_4.txt").ToList());

			foreach(var file in files)
				Console.WriteLine("\nIs palindrome: {0}\n", IsPalindrome(file));

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3kx6oh/20150914_challenge_232_easy_palindromes/");
		}

		static bool IsPalindrome(List<string> strList)
		{
			var str = "";
			foreach(var line in strList)
			{
				Console.WriteLine(line);
				str += new string(line.ToLower().Where(char.IsLetter).ToArray());
			}
			var reverse = new string(str.ToCharArray().Reverse().ToArray());

			if(str == reverse)
				return true;
			return false;
		}
	}
}
