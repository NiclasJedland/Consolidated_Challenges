using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge027
	{
		public static string Description()
		{
			return "String Manipulation: Year to Century";
		}

		public void Challenge_027()
		{
			int year = 0;
			while(true)
			{
				Console.WriteLine("Input year.");				
				try
				{
					year = Int32.Parse(Console.ReadLine());
					Year(year);
					break;
				}
				catch(Exception)
				{
					Console.WriteLine("Input a whole number!");
				}
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/r0r3h/3172012_challenge_27_easy/");
		}


		public static void Year(int year)
		{
			int century = year / 100;
			bool leapYear = false;
			if(year % 4 != 0)
				leapYear = false;
			else if(year % 100 != 0)
				leapYear = true;
			else if(year % 400 != 0)
				leapYear = false;
			else
				leapYear = true;

			if(year % 100 == 0)
				Console.WriteLine(century + "th Century. " + "Leap Year: " + leapYear);
			else
				Console.WriteLine((century + 1) + "th Century. " + "Leap Year: " + leapYear);

		}
	}
}
