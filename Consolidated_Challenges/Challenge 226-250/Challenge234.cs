using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge234
	{
		public static string Description()
		{
			return "Math Problem: Vampire Numbers";
		}

		public void Challenge_234()
		{
			Console.WriteLine("\nCalculating TwoFang number: please wait");
			var sw = Stopwatch.StartNew();
			TwoFangs();
			sw.Stop();
			Console.WriteLine("TwoFang in {0} ms", sw.ElapsedMilliseconds);
			sw.Reset();

			Console.WriteLine("\nCalculating ThreeFang number: please wait");
			sw.Start();
			ThreeFangs();
			sw.Stop();
			Console.WriteLine("ThreeFangs in {0} ms", sw.ElapsedMilliseconds);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3moxid/20150928_challenge_234_easy_vampire_numbers/");
		}

		static void TwoFangs()
		{
			int n = 1000;
			var lst = new List<string>();
			while(n != 99 * 99)
			{
				if(n.ToString().Count(c => c == '0') >= 2)
				{
					n++;
					continue;
				}

				for(int i = 10; i < 100; i++)
				{
					for(int j = i + 1; j < 100; j++)
					{
						if(i * j == n)
						{
							string nstr = String.Concat(n.ToString().OrderBy(c => c));
							string concacted = String.Concat((i.ToString() + j.ToString()).OrderBy(c => c));
							if(concacted == nstr)
							{
								var a = new List<int>() { i, j };
								a.Sort();
								lst.Add(n + "=" + a[0] + "*" + a[1]);
							}
						}
					}
				}
				n++;
			}
			foreach(var s in lst.Distinct())
				Console.WriteLine(s);
		}

		static void ThreeFangs()
		{
			//~61000ms (vanilla) vs ~26000ms (list) vs ~6400ms (array)?
			var nlst = Enumerable.Range(100000, 900000).ToArray();
			var lst = new List<string>();

			for(int i = 10; i < 100; i++)
			{
				for(int j = i + 1; j < 100; j++)
				{
					for(int k = j + 1; k < 100; k++)
					{
						int product = i * j * k;
						if(product.ToString().Count(c => c == '0') >= 2 || product < 100000)
							continue;
						if(nlst.Contains(product))
						{
							string nstr = String.Concat(product.ToString().OrderBy(c => c));
							string concacted = String.Concat((i.ToString() + j.ToString() + k.ToString()).OrderBy(c => c));
							if(concacted == nstr)
							{
								var a = new List<int>() { i, j, k };
								var strings = product.ToString() + "=" + string.Join("*", a.Select(s => s.ToString()));
								lst.Add(strings);
							}
						}
					}
				}
			}
			foreach(var s in lst.Distinct())
				Console.WriteLine(s);
		}

		static IEnumerable<IEnumerable<int>> BuildCombinations(IEnumerable<int> elements, int cols)
		{
			if(cols == 0)
				return new[] { new int[0] };
			return elements.SelectMany((element, index) =>
				BuildCombinations(elements.Skip(index + 1), cols - 1)
					.Select(c => (new[] { element }).Concat(c).ToList()));
		}
	}
}
