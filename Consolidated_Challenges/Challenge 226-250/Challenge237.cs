using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge237
	{
		public static string Description()
		{
			return "String Manipulation: Broken Keyboard";
		}

		public void Challenge_237()
		{
			while(true)
			{
				Console.WriteLine("Which letters can you use?");
				var input = Console.ReadLine();
				Keyboard(input.ToLower());
				Console.WriteLine("Try again?");
				input = Console.ReadLine();
				if(input.ToLower() == "n" || input.ToLower() == "no")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3pcb3i/20151019_challenge_237_easy_broken_keyboard/");
		}

		static void Keyboard(string letters)
		{
			var file = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge237.txt");
			var list = new List<string>();
			foreach(var word in file)
			{
				if(!word.ToLower().Except(letters).Any())
					list.Add(word);
			}

			Console.WriteLine("All words:\n");
			list.ForEach(Console.WriteLine);
			Console.WriteLine("\nLongest word:");
			Console.WriteLine(list.OrderByDescending(s => s.Length).First() + "\n");
		}
	}
}
