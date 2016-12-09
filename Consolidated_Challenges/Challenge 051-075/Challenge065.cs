using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge065
	{
		public static string Description()
		{
			return "Math Problem: Finding Change for Money";
		}

		public void Challenge_065()
		{
			Console.WriteLine("Find change for how much? (ie: '12', '125.25' or '102,75')");
			float findMoney = 0;
			while(true)
			{
				try
				{
					findMoney = float.Parse(Console.ReadLine()) * 100;
					break;
				}
				catch(Exception)
				{
					Console.WriteLine("Only accepting numbers. 12, 125, 125.50");				
				}
			}
			CalculateChange(findMoney);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/v3a89/6152012_challenge_65_easy/");
		}

		public static void CalculateChange(float change)
		{
			Dictionary<string, int> money = new Dictionary<string, int>()
			{   {"Thousand-dollar bill", 100000}, {"Fivehundred-dollar bill", 50000}, {"Hundred-dollar bill", 10000}, {"Fifty-dollar bill", 5000}, {"Ten-dollar bill", 1000},
				{"Five-dollar bill", 500}, {"One-dollar bill", 100},  {"Quarter", 025}, {"Dime", 10}, {"Nickel", 5}, {"Penny", 1}               };

			List<int> changeInt = new List<int>();
			List<string> changeString = new List<string>();

			for(int i = 0; change > 0; i++)
			{
				while(change >= money.ElementAt(i).Value)
				{
					change -= money.ElementAt(i).Value;

					if(changeString.Contains(money.ElementAt(i).Key))
						changeInt[changeInt.Count - 1] += 1;
					else
					{
						changeInt.Add(1);
						changeString.Add(money.ElementAt(i).Key);
					}
				}
			}
			Console.WriteLine("You will need: ");
			for(int i = 0; i < changeInt.Count; i++)
			{
				Console.WriteLine("{0}: {1}", changeString[i], changeInt[i]);
			}
		}
	}
}
