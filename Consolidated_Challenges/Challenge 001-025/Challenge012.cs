using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge012
	{
		public static string Description()
		{
			return "String Manipulation: Permutations";
		}

		public void Challenge_012()
		{
			Console.WriteLine("Input string to count permutations (6+ characters is slow)");
			string inputLine = Console.ReadLine();

			Recursion rec = new Recursion();
			rec.InputSet = rec.MakeCharArray(inputLine);
			rec.CalcPermutation(0);

			Console.WriteLine("# of Permutations: " + rec.PermutationCount);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pxs2x/2202012_challenge_12_easy/");
		}
	}

	class Recursion
	{
		private int elementLevel = -1;
		private int numberOfElements;
		private int[] permutationValue = new int[0];

		private char[] inputSet;
		public char[] InputSet
		{
			get { return inputSet; }
			set { inputSet = value; }
		}

		private int permutationCount = 0;
		public int PermutationCount
		{
			get { return permutationCount; }
			set { permutationCount = value; }
		}

		public char[] MakeCharArray(string InputString)
		{
			char[] charString = InputString.ToCharArray();
			Array.Resize(ref permutationValue, charString.Length);
			numberOfElements = charString.Length;
			return charString;
		}

		public void CalcPermutation(int k)
		{
			elementLevel++;
			permutationValue.SetValue(elementLevel, k);

			if(elementLevel == numberOfElements)
			{
				OutputPermutation(permutationValue);
			}
			else
			{
				for(int i = 0; i < numberOfElements; i++)
				{
					if(permutationValue[i] == 0)
					{
						CalcPermutation(i);
					}
				}
			}
			elementLevel--;
			permutationValue.SetValue(0, k);
		}

		private void OutputPermutation(int[] value)
		{
			foreach(int i in value)
			{
				Console.Write(inputSet.GetValue(i - 1));
			}
			Console.WriteLine();
			PermutationCount++;
		}
	}
}
