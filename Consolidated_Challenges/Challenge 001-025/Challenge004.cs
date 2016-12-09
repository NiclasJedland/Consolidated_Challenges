using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge004
	{
		public static string Description()
		{
			return "String Manipulation: Random Password Generator";
		}

		public void Challenge_004()
		{	
			Random random = new Random();
			while(true)
			{
				Console.WriteLine("Random Password Generator\nHow many characters do you want?");
				var length = Console.ReadLine();
				int pswLength = 0;
				Console.WriteLine("How many passwords do you want?");
				var amount = Console.ReadLine();
				int amountOfPsw = 0;

				string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZabcdefghiklmnopqrstuvwxyz!@#$%^&*(!@#$%^&*)_.-+/";
				string password = "";

				if(int.TryParse(length, out pswLength) && int.TryParse(amount, out amountOfPsw))
				{
					for(int i = 1; i <= amountOfPsw; i++)
					{
						password = "";
						for(int j = 0; j < pswLength; j++)
						{
							int num = random.Next(chars.Length);
							password += chars[num];
						}
						Console.WriteLine("#"+ i + " " + password);
					}
				}
				else
					Console.WriteLine("Number of characters or number of passwords isn't a whole number.");

				Console.WriteLine("Want to try again? y/n");
				string again = Console.ReadLine();
				if(again.ToLower() == "n" || again.ToLower() == "no")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pm6oj/2122012_challenge_4_easy/");
		}
	}
}
