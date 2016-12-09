using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge007
	{
		public static string Description()
		{
			return "String Manipulation: Morse Code";
		}

		public void Challenge_007()
		{	
			var test = FromMorse(".... . .-.. .-.. --- / -.. .- .. .-.. -.-- / .--. .-. --- --. .-. .- -- -- . .-. / --. --- --- -.. / .-.. ..- -.-. -.- / --- -. / - .... . / -.-. .... .- .-.. .-.. . -. --. . ... / - --- -.. .- -.--");
			var test2 = ToMorse("This is a test");

			Console.WriteLine(".... . .-.. .-.. --- / -.. .- .. .-.. -.-- / .--. .-. --- --. .-. .- -- -- . .-. / --. --- --- -.. / .-.. ..- -.-. -.- / --- -. / - .... . / -.-. .... .- .-.. .-.. . -. --. . ... / - --- -.. .- -.--");
			Console.WriteLine(test);
			Console.WriteLine("This is a test");
			Console.WriteLine(test2);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pr2xr/2152012_challenge_7_easy/");
		}

		public static string ToMorse(string word)
		{
			word = word.ToUpper();

			Dictionary<char, string> dic = new Dictionary<char, string>()
			{   {'A', ".-"}, {'B',"-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."},
				{'J', ".---"}, {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
				{'S', "..."}, {'T', "-"}, {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."}, {'1', ".----"},
				{'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
				{'0', "-----"}, {'?', "..--.. "},{'!', "-.-.-- "},{'$', "...-..- "}, {' ', "/"} };
			StringBuilder morse = new StringBuilder();

			foreach(char letter in word)
			{
				morse.Append(dic[letter] + " ");
			}
			return morse.ToString();
		}

		public static string FromMorse(string word)
		{
			string[] stuff = word.Split(' ');

			Dictionary<string, char> dic = new Dictionary<string, char>()
			{   {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'}, {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'},
				{".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'}, {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'},
				{"...", 'S'}, {"-", 'T'}, {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'}, {"--..", 'Z'}, {".----", '1'},
				{"..---", '2'}, {"...--", '3'}, {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'}, {"----.", '9'},
				{"-----", '0'}, {"..--.. ", '?'}, {"-.-.-- ", '!'}, {"...-..- ", '$'}, {"/", ' '}       };
			StringBuilder morse = new StringBuilder();

			foreach(var w in stuff)
			{
				morse.Append(dic[w]);
			}

			return morse.ToString();
		}

	}
}
