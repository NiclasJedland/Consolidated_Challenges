using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge063
	{
		public static string Description()
		{
			return "List Manipulation: Reverse N Items";
		}

		public void Challenge_063()
		{
			int[] intArray = new int[] { 1, 2, 3, 4, 5 };
			var intList = new List<int>() { 1, 2, 3, 4, 5 };

			Console.WriteLine("With List");
			ReverseList(1, intList);
			ReverseList(2, intList);
			ReverseList(3, intList);
			ReverseList(4, intList);
			ReverseList(5, intList);
			ReverseList(6, intList);
			Console.WriteLine();
			Console.WriteLine("With Array");
			ReverseArray(1, intArray);
			ReverseArray(2, intArray);
			ReverseArray(3, intArray);
			ReverseArray(4, intArray);
			ReverseArray(5, intArray);
			ReverseArray(6, intArray);

			Console.WriteLine("\nWish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/uw14f/6112012_challenge_63_easy/");
		}

		public static void ReverseList(int n, List<int> intList)
		{
			var tempList = new List<int>(intList);
			if(n >= tempList.Count)
				tempList.Reverse();
			else
				tempList.Reverse(0, n);				
			for(int i = 0; i < tempList.Count; i++)
				Console.Write(tempList[i]);
			Console.WriteLine();
		}

		public static void ReverseArray(int n, int[] intArray)
		{
			int[] tempArray = new int[intArray.Length];
			Array.Copy(intArray, tempArray, intArray.Length);
			if(n >= tempArray.Length)
				Array.Reverse(tempArray);
			else
				Array.Reverse(tempArray, 0, n);
			for(int i = 0; i < tempArray.Length; i++)
				Console.Write(tempArray[i]);
			Console.WriteLine();
		}
	}
}
