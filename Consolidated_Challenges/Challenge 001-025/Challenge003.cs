using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge003
	{
		public static string Description()
		{
			return "String Manipulation: Simple Cipher/Decipher";
		}

		public void Challenge_003()
		{
			Console.WriteLine("String to cipher and uncipher.");
			string a = Console.ReadLine();
			string b = Cipher(a, 18);
			string c = Cipher(b, -18);

			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pkw2m/2112012_challenge_3_easy/");
		}

		public static string Cipher(string a, int shift)
		{
			char[] test = a.ToLower().ToCharArray();
			for(var i = 0; i < test.Length; i++)
			{
				char letter = test[i];

				if(char.IsLetter(letter))
				{
					letter = (char)(letter + shift);

					if(letter > 'z')
					{
						letter = (char)(letter - 26);
					}
					else if(letter < 'a')
					{
						letter = (char)(letter + 26);
					}
				}
				test[i] = letter;
			}
			return new string(test);
		}
	}
}
