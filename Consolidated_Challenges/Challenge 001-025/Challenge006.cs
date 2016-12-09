using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge006
	{
		public static string Description()
		{
			return "Math: Calculate Pi";
		}

		public void Challenge_006()
		{
			Console.WriteLine("Calculate Pi to how many decimals?");
			int places = int.Parse(Console.ReadLine());
			Console.WriteLine(CalculatePi(places));

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pp53w/2142012_challenge_6_easy/");
		}

		public static string CalculatePi(int digits)
		{
			string result = "";
			digits++;

			uint[] x = new uint[digits * 3 + 2];
			uint[] r = new uint[digits * 3 + 2];

			for(int j = 0; j < x.Length; j++)
				x[j] = 20;

			for(int i = 0; i < digits; i++)
			{
				uint carry = 0;
				for(int j = 0; j < x.Length; j++)
				{
					uint num = (uint)(x.Length - j - 1);
					uint dem = num * 2 + 1;

					x[j] += carry;

					uint q = x[j] / dem;
					r[j] = x[j] % dem;

					carry = q * num;
				}
				if(i < digits - 1)
					result += (x[x.Length - 1] / 10).ToString();
				r[x.Length - 1] = x[x.Length - 1] % 10;
				;
				for(int j = 0; j < x.Length; j++)
					x[j] = r[j] * 10;
			}
			return result;
		}
	}
}
