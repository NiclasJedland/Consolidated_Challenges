using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge011
	{
		public static string Description()
		{
			return "Math Problem: Calculate Day";
		}

		public void Challenge_011()
		{
			Console.WriteLine("What year?");
			int year = Int32.Parse(Console.ReadLine());
			if(year < 1)
				year = 1;

			Console.WriteLine("What month? 1-12");
			int month = Int32.Parse(Console.ReadLine());
			if(month > 12)
				month = 12;
			
			Console.WriteLine("What day? 1-31");
			int day = Int32.Parse(Console.ReadLine());
			if(day > 31)
				day = 31;
			string test = GetDay(day, month, year);

			Console.WriteLine(test);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pwons/2192012_challenge_11_easy/");
		}

		public static string GetDay(int day, int month, int year)
		{
			double Y, d, m, y, c, w;

			if(month == 0 || month == 1)
				Y = year - 1;
			else
				Y = year;

			d = day;
			m = ((month + 9) % 12) + 1;
			y = Y % 100;
			c = Y / 100;
			w = (int)(d + Math.Floor(2.6 * m - 0.2) + y + Math.Floor(y / 4) + Math.Floor(c / 4) - 2 * c);
			w %= 7;

			string output = DayToText((int)w);
			return output;
		}
		
		public static string DayToText(int day)
		{
			if(day == 0)
				return "Monday";
			else if(day == 1)
				return "Tuesday";
			else if(day == 2)
				return "Wednesday";
			else if(day == 3)
				return "Thursday";
			else if(day == 4)
				return "Friday";
			else if(day == 5)
				return "Saturday";
			else if(day == 6)
				return "Sunday";
			else
				return "-1";
		}
	}
}
