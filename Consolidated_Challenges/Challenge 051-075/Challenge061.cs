using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge061
	{
		public static string Description()
		{
			return "String Manipulation: Binary Rotating Number";
		}

		public void Challenge_061()
		{
			List<int> number = new List<int>() { 19, 69, 205, 357, 54321 };

			foreach(var s in number)
			{
				RotateBinary(s);
				Console.WriteLine("\n\n");
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/uo11f/662012_challenge_61_easy/");
		}

		public static void RotateBinary(int number)
		{
			string binary = ConvertToBinary(number);

			Console.Write(number + " " + binary);

			while(binary.Contains("0"))
			{
				char[] ph = binary.ToCharArray();
				char temp = ph[ph.Length - 1];
				for(int i = ph.Length - 1; i >= 0; i--)
				{
					if(i != 0)
						ph[i] = ph[i - 1];
					else
						ph[0] = temp;
				}
				binary = new string(ph);

				if(binary[0] == '0')
					binary = binary.Substring(1);

				Console.Write(" --> " + ConvertToNumber(binary) + " " + binary);
			}
		}


		public static string ConvertToBinary(int number)
		{
			return Convert.ToString(number, 2);
		}

		public static int ConvertToNumber(string number)
		{
			return Convert.ToInt32(number, 2);
		}
	}
}
