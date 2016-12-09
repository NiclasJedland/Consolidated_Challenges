using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge059
	{
		public static string Description()
		{
			return "String Manipulation: Substring Location";
		}

		public void Challenge_059()
		{
			string firstString = "Oil, double, toil and oil a trouble";
			string secondString = "il an";
			int easy = 0;
			int hard = 0;
			//easy
			if(firstString.Contains(secondString))
			{
				easy = firstString.IndexOf(secondString);
				Console.WriteLine("Easy way: Second string (il an) starts at the " + easy + " letter.");
			}
			//hard
			var intList = new List<int>();
			if(firstString.Contains(secondString))
			{
				for(int i = 0; i < firstString.Length; i++)
				{
					if(firstString[i] == secondString[0])
					{
						intList.Add(i);
					}
				}
			}
			string temp;
			foreach(var index in intList)
			{
				if((index + secondString.Length) > firstString.Length)
				{
					break;
				}
				temp = firstString.Substring(index, secondString.Length);
				if(temp.Equals(secondString))
				{
					hard = index;
				}
			}
			Console.WriteLine("Hard way: Second string (il an) starts at the " + hard + " letter.");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/uh033/622012_challenge_59_easy/");
		}
	}
}
