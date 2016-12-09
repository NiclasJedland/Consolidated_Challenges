using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge001
	{
		public static string Description()
		{
			return "String Manipulation: Simple Input/Output";
		}

		public void Challenge_001()
		{
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			Console.WriteLine("What is your age?");
			var age = Console.ReadLine();
			Console.WriteLine("What is your username?");
			var username = Console.ReadLine();

			Console.WriteLine("Your name is " + name + " and you are " + age + " years old, and your username is " + username);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pih8x/easy_challenge_1/");
		}
	}
}
