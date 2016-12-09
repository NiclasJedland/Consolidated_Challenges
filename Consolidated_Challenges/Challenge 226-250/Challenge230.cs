using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Consolidated_Challenges
{
	public class Challenge230
	{
		public static string Description()
		{
			return "String Manipulation: Json Treasure Hunt";
		}

		public void Challenge_230()
		{
			var file1 = Directory.GetCurrentDirectory() + @"\challenge230_1.txt";
			var file2 = Directory.GetCurrentDirectory() + @"\challenge230_2.txt";

			Console.WriteLine(Reveal(file1, "dailyprogrammer"));
			Console.WriteLine(Reveal(file2, "dailyprogrammer"));

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3j3pvm/20150831_challenge_230_easy_json_treasure_hunt/");
		}

		public static string Reveal(string input, string searchString)
		{
			using(var sr = new StreamReader(input))
			using(var reader = new JsonTextReader(sr))
			{
				while(reader.Read())
				{
					if(reader.ValueType == typeof(string) && reader.Value.Equals(searchString))
						return FormatPath(reader.Path);
				}
			}
			return null;
		}

		static string FormatPath(string path)
		{
			return !string.IsNullOrWhiteSpace(path)
				? Regex.Replace(path.Replace(".", " -> "), @"(\[)(\d)(\])", " -> $2")
				: null;
		}
	}
}
