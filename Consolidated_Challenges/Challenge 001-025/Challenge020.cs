using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge020
	{
		public static string Description()
		{
			return "Math Problem: Calculate Primes";
		}

		public void Challenge_020()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			int numOfLines = 12;
			int numberOfPrimes = 10000;
			int line = numOfLines;
			for(int i = 3; i > 0; i += 2)
			{
				//Change this to IsPrime2 to check the slower version
				if(IsPrime(i)) 
				{
					if(line == 1)
					{
						Console.Write(i.ToString() + "\n");
						line = numOfLines;
					}
					else if(numberOfPrimes == 0)
						break;
					else
					{
						Console.Write(i.ToString() + " ");
						line--;
					}
					numberOfPrimes--;
				}
			}
			sw.Stop();
			Console.WriteLine("\n\n" + sw.ElapsedMilliseconds + "ms");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qnkro/382012_challenge_20_easy/");
		}

		//fast
		static bool IsPrime(int num)
		{
			for(int i = 2; i * i <= num; i++)
			{
				if((num % i) == 0)
					return false;
			}
			return true;
		}

		//slow
		public static bool IsPrime2(int n)
		{
			return Enumerable.Range(2, (int)Math.Ceiling(Math.Sqrt(n))).AsParallel().All(pr => n % pr != 0);
		}
	}
}
