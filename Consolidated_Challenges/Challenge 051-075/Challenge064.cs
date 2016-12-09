using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge064
	{
		public static string Description()
		{
			return "Math Problem: Divisors, Coprimes and Totatives";
		}

		public void Challenge_064()
		{
			Console.WriteLine("Check divisors, coprimes and totatives of a number.");
			int number = int.Parse(Console.ReadLine());

			List<int> divisors = GetDivisors(number);
			List<int> totatives = GetTotatives(number);

			int divCount = GetDivisorCount(number);
			int divSum = GetDivisorSum(number);

			int totCount = GetTotativesCount(number);
			int totSum = GetTotativesSum(number);

			Console.Write("Divisors: ");
			foreach(var s in divisors)
				Console.Write(s + " ");

			Console.Write("\nNumber of divisors: {0}\nSum of divisors: {1} ", divCount, divSum);

			Console.Write("\n\nTotatives: ");
			foreach(var s in totatives)
				Console.Write(s + " ");

			Console.Write("\nNumber of totatives: {0}\nSum of totatives: {1} ", totCount, totSum);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/uzx8b/6132012_challenge_64_easy/");
		}


		public static List<int> GetDivisors(int number)
		{
			List<int> divisors = new List<int>();
			int sum = 0;
			int nrOf = 0;

			for(int i = 1; i <= number; i++)
			{
				if(number % i == 0)
				{
					nrOf++;
					divisors.Add(i);
					sum += i;
				}
			}
			return divisors;
		}


		public static List<int> GetTotatives(int number)
		{
			List<int> totatives = new List<int>();

			int sum = 0;
			int nrOf = 0;
			totatives.Add(1);

			for(int i = 3; i <= number; i += 2)
			{
				if(IsPrimeNumber(i) && number % i != 0)
				{
					nrOf++;
					totatives.Add(i);
					sum += i;
				}
			}
			return totatives;
		}


		static bool IsPrimeNumber(int num)
		{
			bool prime = true;
			int factor = num / 2;

			for(var i = 2; i <= factor; i++)
			{
				if((num % i) == 0)
					prime = false;
			}
			return prime;
		}


		public static int GetDivisorCount(int n)
		{
			return GetDivisors(n).Count;
		}


		public static int GetDivisorSum(int n)
		{
			return GetDivisors(n).Sum();
		}


		public static int GetTotativesCount(int n)
		{
			return GetTotatives(n).Count;
		}


		public static int GetTotativesSum(int n)
		{
			return GetTotatives(n).Sum();
		}
	}
}
