using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge224
	{
		public static string Description()
		{
			return "List Manipulation: Shuffling a List";
		}

		public void Challenge_224()
		{
			var nums = "1 2 3 4 5 6 7 8";
			var words = "apple blackberry cherry dragonfruit grapefruit kumquat mango nectarine persimmon raspberry raspberry";
			Console.WriteLine("Original: {0}", nums);
			Randomize(nums);
			Console.WriteLine("Original: {0}", words);
			Randomize(words);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3e0hmh/20150720_challenge_224_easy_shuffling_a_list/");
		}
		
		static void Randomize(string input)
		{
			var list = input.Split(' ');
			Random rnd = new Random();
			var randomizedList = from item in list
								 orderby rnd.Next()
								 select item;
			foreach(var s in randomizedList)
				Console.Write(s + " ");
			Console.WriteLine();
		}
	}
}
