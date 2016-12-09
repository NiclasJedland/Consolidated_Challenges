using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge013
	{
		public static string Description()
		{
			return "Math Problem: Calculate Day of the Year";
		}

		public void Challenge_013()
		{
			string leapYear = "";
			Console.Write("Enter the month(as number): ");
			int month = int.Parse(Console.ReadLine());
			Console.Write("Enter the day (1-31): ");
			int day = int.Parse(Console.ReadLine());

			if(month > 2 || (month == 2 && day == 29))
			{
				Console.Write("Is it a leap year? (y/n): ");
				leapYear = Console.ReadLine();
			}

			if((leapYear.ToLower() == "y" && month > 2) || (month == 2 && day == 29))
				Console.WriteLine(CalcDay(day, month, true));
			else
				Console.WriteLine(CalcDay(day, month, false));

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pzo4w/2212012_challenge_13_easy/");
		}

		public static int CalcDay(int day, int month, bool leapYear)
		{
			int weekday = 0;
			var months = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if(leapYear)
				months[1] = 29;

			int i = month - 1;

			while(i > 0)
			{
				weekday += months[i];
				--i;
			}
			return weekday += day;
		}
	}
}
