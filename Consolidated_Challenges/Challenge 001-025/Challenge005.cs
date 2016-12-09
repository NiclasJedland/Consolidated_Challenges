using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge005
	{
		public static string Description()
		{
			return "String Manipulation: Password";
		}

		public void Challenge_005()
		{
			string username = "user";
			string password = "pass";
			int count = 0;
			while(true)
			{
				Console.WriteLine("Enter username");
				string user = Console.ReadLine();
				Console.WriteLine("Enter password");
				string pass = Console.ReadLine();

				if(user == username && pass == password)
				{
					Console.WriteLine("You are logged in!");
					break;
				}
				if(count < 2)
				{
					Console.WriteLine("Too many tries.");
					break;
				}
				else
				{
					count++;
					Console.WriteLine("Wrong password or username");
				}
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pnhyn/2122012_challenge_5_easy/");
		}
	}
}
