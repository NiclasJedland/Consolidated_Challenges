using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge229
	{
		public static string Description()
		{
			return "Math Problem: The Dottie Number, Bonus: PI & Golden Ratio";
		}

		public void Challenge_229()
		{
			Dottie(3);
			Pi(3);
			GoldenRatio(3);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3i99w8/20150824_challenge_229_easy_the_dottie_number/");
		}

		static void Dottie(double a)
		{
			while(a != Math.Cos(a))
				a = Math.Cos(a);
			Console.WriteLine("Dottie number: {0}", a);
		}

		static void Pi(double a)
		{
			while(a != a - Math.Tan(a))
				a -= Math.Tan(a);
			Console.WriteLine("PI: {0}", a);
		}

		static void GoldenRatio(double a)
		{
			while(a != 1 + 1 / a)
				a = 1 + 1 / a;
			Console.WriteLine("Golden Ratio: {0}", a);
		}

	}
}
