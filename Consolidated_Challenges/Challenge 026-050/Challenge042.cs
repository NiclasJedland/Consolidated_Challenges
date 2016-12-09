using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge042
	{
		public static string Description()
		{
			return "String Manipulation: Bottles";
		}

		public void Challenge_042()
		{
			string[] ones = { "", "-one", "-two", "-three", "-four", "-five", "-six", "-seven", "-eight", "-nine" };
			string[] Ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
			string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
			string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
			string word = "Ninety-nine";

			int index = 0;

			for(int i = 98; i >= -1; i--)
			{
				Console.WriteLine(word + " bottle" + (i == 0 ? "" : "s") + " of beer on the wall.");
				Console.WriteLine(word + " bottle" + (i == 0 ? "" : "s") + " of beer.");

				if(i > -1)
					Console.WriteLine("Take one down, pass it around.\n");
				word = "";

				if((i > 19 || i < 11) && i > 0)
				{
					index = (i / 10);
					if(index >= 0)
						word += tens[index];
					index = (i % 10);
					if(index >= 0)
					{
						if(i / 10 > 0)
							word += (ones[index]);
						else
							word += (Ones[index]);
					}

				}
				else if(i > 0)
					word += teens[i - 10];
				else
					word = "No";
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/sobna/4232012_challenge_42_easy/");
		}
	}
}
