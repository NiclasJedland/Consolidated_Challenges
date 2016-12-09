using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge032
	{
		public static string Description()
		{
			return "Math Problem: Casino";
		}

		public void Challenge_032()
		{	
			while(true)
			{
				string input = "";
				int numberCount = 0;
				int count = 0;
				int money = 0;

				Console.WriteLine("How many numbers will you bet on? Applicable: \nnumbers(1-6, 12, 18), odd, even"/*, red, black*/);
				input = Console.ReadLine();
				input = input.ToLower();

				int[] betNumber = new int[count];

				if((int.TryParse(input, out count) && (Enumerable.Range(1, 6).Contains(count) || count == 12 || count == 18)))
				{
					betNumber = new int[count];
					while(numberCount < count)
					{
						Console.Write("Number {0}? ", numberCount + 1);
						betNumber[numberCount] = Int32.Parse(Console.ReadLine());
						numberCount++;
					}
					Console.WriteLine("How many $ do you want to bet?");
					money = int.Parse(Console.ReadLine());
					WinningNumber(betNumber, money, input);
				}
				else if(input == "odd" || input == "even" || input == "red" || input == "black")
				{
					Console.WriteLine("How many $ do you want to bet?");
					money = int.Parse(Console.ReadLine());
					WinningNumber(betNumber, money, input);
				}
				else
					Console.WriteLine("Unknown command ");

				Console.WriteLine("Want to play again?");
				input = Console.ReadLine();
				if(input.ToLower() == "n" || input.ToLower() == "no")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/rhrmx/3282012_challenge_32_easy/");
		}

		public static void WinningNumber(int[] bettingNumber, int money, string str)
		{

			int numberOfBets = bettingNumber.Length;
			Random random = new Random();
			int winningNumber = random.Next(0, 36);
			bool won = false;

			for(int i = 0; i < bettingNumber.Length; i++)
			{
				if(winningNumber == bettingNumber[i] && numberOfBets == 1)
				{
					Console.WriteLine("You won! $" + money * 37 + ". Winning number: " + winningNumber);
					won = true;
				}
				else if(winningNumber == bettingNumber[i])
				{
					if(numberOfBets == 2)
						Console.WriteLine("You won! $" + money * 18 + ". Winning number: " + winningNumber);
					else if(numberOfBets == 3)
						Console.WriteLine("You won! $" + money * 11.667f + ". Winning number: " + winningNumber);
					else if(numberOfBets == 4)
						Console.WriteLine("You won! $" + money * 8.5f + ". Winning number: " + winningNumber);
					else if(numberOfBets == 5)
						Console.WriteLine("You won! $" + money * 6.6f + ". Winning number: " + winningNumber);
					else if(numberOfBets == 6)
						Console.WriteLine("You won! $" + money * 5.33f + ". Winning number: " + winningNumber);
					else if(numberOfBets == 12)
						Console.WriteLine("You won! $" + money * 2.167f + ". Winning number: " + winningNumber);
					else if(numberOfBets == 18)
						Console.WriteLine("You won! $" + money * 1.111f + ". Winning number: " + winningNumber);

					won = true;
				}
			}

			if(str == "odd" || str == "even" || str == "red" || str == "black")
			{
				if(str.ToLower() == "odd" && winningNumber % 2 == 1)
				{
					Console.WriteLine("You won! $" + money * 1.111f + ". Winning number: " + winningNumber);
					won = true;
				}
				else if(str.ToLower() == "even" && winningNumber % 2 == 0)
				{
					Console.WriteLine("You won! $" + money * 1.111f + ". Winning number: " + winningNumber);
					won = true;
				}
				else if(str.ToLower() == "half(1st)" && Enumerable.Range(1, 18).Contains(winningNumber))
				{
					Console.WriteLine("You won! $" + money * 1.111f + ". Winning number: " + winningNumber);
					won = true;
				}
				else if(str.ToLower() == "half(2nd)" && Enumerable.Range(19, 36).Contains(winningNumber))
				{
					Console.WriteLine("You won! $" + money * 1.111f + ". Winning number: " + winningNumber);
					won = true;
				}				
			}
			if(won == false)
				Console.WriteLine("You lost $" + money + ". The winning number: " + winningNumber);
		}
	}
}
