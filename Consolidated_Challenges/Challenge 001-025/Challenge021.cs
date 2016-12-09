using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge021
	{
		public static string Description()
		{
			return "List Manipulation: Number Parsing";
		}
		
		public void Challenge_021()
		{
			Console.WriteLine("Input a number");
			int number = Int32.Parse(Console.ReadLine());

			int nextNumber = GetNextNumber(number);

			if(nextNumber == number)
				Console.WriteLine("No higher number than: " + number);
			else
				Console.WriteLine("Next number is: " + nextNumber);
		
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qp3ub/392012_challenge_21_easy/");
		}

		public static int GetNextNumber(int number)
		{
			int lengthOfNumber = number.ToString().Length;
			int tempNumber = number;
			string highestNumber = number.ToString();
			int[] numbersArray = new int[highestNumber.Length];

			Console.WriteLine(lengthOfNumber);

			//get each number to array
			for(int i = lengthOfNumber - 1; i >= 0; i--)
			{
				numbersArray[i] = (int)(tempNumber % 10);
				tempNumber = tempNumber / 10;
			}

			for(int i = 0; i < highestNumber.Length; i++)
			{
				Console.WriteLine("Array element[{0}] is: {1} ", i, numbersArray[i]);
			}

			for(int i = lengthOfNumber - 1; i > 0; i--)
			{
				for(int j = lengthOfNumber - 2; j >= 0; j--)
				{
					if(numbersArray[i] > numbersArray[j])
					{
						int temp = numbersArray[i];
						numbersArray[i] = numbersArray[j];
						numbersArray[j] = temp;
						for(i = j + 1; i < lengthOfNumber - 1; i++)
						{
							for(j = i + 1; j < lengthOfNumber; j++)
							{
								if(numbersArray[i] > numbersArray[j])
								{
									temp = numbersArray[i];
									numbersArray[i] = numbersArray[j];
									numbersArray[j] = temp;
								}
							}
						}
						int toReturn = 0;
						for(i = 0; i < lengthOfNumber; i++)
						{
							toReturn = toReturn + (int)(numbersArray[i] * Math.Pow(10, (lengthOfNumber - 1 - i)));
						}
						return toReturn;
					}
				}
			}
			return number;
		}
	}
}
