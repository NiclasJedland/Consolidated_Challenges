using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge040
	{
		public static string Description()
		{
			return "Loops: Several Ways to Loop";
		}

		public void Challenge_040()
		{
			int target = 10;
			
			ForLoop(target);
			WhileLoop(target);
			ForeachLoop(target);
			Enumerable.Range(1, target).ToList().ForEach(Console.WriteLine);
			Console.WriteLine(Recursion(target, 1));

			Console.WriteLine("\nfor(int i = 1; i <= target; i++)\n  Console.WriteLine(i);");
			Console.WriteLine("\nint x = 1;\nwhile(true)\n{\n  Console.WriteLine(x);\n  x++;\n  if(x > target)\n    break;\n}");
			Console.WriteLine("\nforeach(var item in Enumerable.Range(1, target))\n}\n  Console.WriteLine(item);\n}\n");
			Console.WriteLine("Enumerable.Range(1, target).ToList().ForEach(Console.WriteLine);");
			Console.WriteLine("\nRecursion();\npublic int Recursion()\n{\n  if(current == target)\n    return current;\n  Console.WriteLine(current);\n  return Recursion(target, current+1);\n}\n");
			
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/schtf/4162012_challenge_40_easy/");
		}

		public void ForLoop(int target)
		{
			for(int i = 1; i <= target; i++)
				Console.WriteLine(i);
		}

		public void WhileLoop(int target)
		{
			int x = 1;
			while(true)
			{
				Console.WriteLine(x);
				x++;
				if(x > target)
					break;
			}
		}

		public void ForeachLoop(int target)
		{
			foreach(var item in Enumerable.Range(1, target))
			{
				Console.WriteLine(item);
			}
		}

		public int Recursion(int target, int current)
		{
			if(current == target)
				return current;
			Console.WriteLine(current);
			return Recursion(target, current+1);
		}
	}
}
