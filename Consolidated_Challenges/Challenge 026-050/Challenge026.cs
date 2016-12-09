using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge026
	{
		public static string Description()
		{
			return "String Manipulation: Duplicate Letter Separation";
		}

		public void Challenge_026()
		{
			Separate("ddaaiillyypprrooggrraammeerr");
			Separate("balloons");
			Separate("aabbccddeded");
			Separate("flabby aapples");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qzil1/3162012_challenge_26_easy/");
		}

		public static void Separate(string originalString)
		{
			string duplicates = "";
			string realString = "";

			for(int i = 0; i < originalString.Length; i++)
			{

				int j = i + 1;
				if(j >= originalString.Length)
					realString += originalString[i];
				else
				{

					if(originalString[i] == originalString[j])
					{
						duplicates += originalString[i];
						realString += originalString[i];
						i++;
					}
					else
						realString += originalString[i];
				}
			}
			Console.WriteLine(originalString);
			Console.WriteLine(realString + " " + duplicates);
			Console.Write("\n");
		}
	}
}
