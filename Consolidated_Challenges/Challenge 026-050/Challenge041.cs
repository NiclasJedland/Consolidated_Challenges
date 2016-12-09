using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge041
	{
		public static string Description()
		{
			return "String Manipulation: Frameify";
		}

		public void Challenge_041()
		{
			Console.WriteLine("Write something.");
			string something = Console.ReadLine();
			int somethingLength = something.Length;

			for(int i = 0; i < somethingLength + 6; i++)
				Console.Write("*");

			Console.Write("\n*");

			for(int i = 0; i < somethingLength + 4; i++)
				Console.Write(" ");

			Console.Write("*\n*  " + something + "  *\n*");

			for(int i = 0; i < somethingLength + 4; i++)
				Console.Write(" ");

			Console.Write("*\n");

			for(int i = 0; i < somethingLength + 6; i++)
				Console.Write("*");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/shp28/4192012_challenge_41_easy/");
		}

	}
}
