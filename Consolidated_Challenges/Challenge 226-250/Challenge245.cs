using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge245
	{
		public static string Description()
		{
			return "String Manipulation: Date Dilemma";
		}

		public void Challenge_245()
		{
			var inputDates = new List<string>() { "2/13/15", "1-31-10", "5 10 2015", "2012 3 17", "2001-01-01", "2008/01/07" };

			foreach(var date in inputDates)
			{
				Console.WriteLine(ToISO8601(date));
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3wshp7/20151214_challenge_245_easy_date_dilemma/");
		}

		string ToISO8601(string date)
		{
			try
			{
				date = date.Replace("/", "-");
				date = date.Replace(" ", "-");

				var dateList = date.Split('-').ToList();

				if(dateList[0].Length > 2)
					return dateList[0] + "-" + dateList[1].PadLeft(2, '0') + "-" + dateList[2].PadLeft(2, '0');
				else if(dateList.Any(s => s.Length > 2))
					return dateList[2] + "-" + dateList[0].PadLeft(2, '0') + "-" + dateList[1].PadLeft(2, '0');
				else
					return "20" + dateList[2] + "-" + dateList[0].PadLeft(2, '0') + "-" + dateList[1].PadLeft(2, '0');
			}
			catch(Exception)
			{
				return "invalid date: " + date;
			}
		}

	}
}
