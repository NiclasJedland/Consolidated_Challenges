using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge220
	{
		public static string Description()
		{
			return "String Manipulation: Mangling Sentences";
		}

		public void Challenge_220()
		{
			string input1 = "This challenge doesn't seem so hard.";
			string input2 = "There are more things between heaven and earth, Horatio, than are dreamt of in your philosophy. ";
			string input3 = "Eye of Newt, and Toe of Frog, Wool of Bat, and Tongue of Dog.";
			string input4 = "Adder's fork, and Blind-worm's sting, Lizard's leg, and Howlet's wing. ";
			string input5 = "For a charm of powerful trouble, like a hell-broth boil and bubble.";
			Console.WriteLine(Sort(input1) + "\n");
			Console.WriteLine(Sort(input2) + "\n");
			Console.WriteLine(Sort(input3) + "\n");
			Console.WriteLine(Sort(input4) + "\n");
			Console.WriteLine(Sort(input5) + "\n");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3aqvjn/20150622_challenge_220_easy_mangling_sentences/");
		}

		static string Sort(string input)
		{
			Console.WriteLine("Original string: " + input);
			string output = "";
			var splitted = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			foreach(var word in splitted)
				output += OrderWord(word) + " ";
			return output;
		}
		
		private static string OrderWord(string word)
		{
			bool captial = char.IsUpper(word[0]);
			var chars = word.ToCharArray();

			for(int i = 0; i < chars.Length; i++)
			{
				var c = chars[i];
				if(char.IsPunctuation(c))
					continue;

				for(int x = 0; x < chars.Length; x++)
				{
					var _c = chars[x];
					if(i == x)
						continue;
					if(char.IsPunctuation(_c))
						continue;
					if(_c > c)
					{
						chars[i] = _c;
						chars[x] = c;
						c = _c;
					}
				}
			}
			if(captial)
				chars[0] = char.ToUpper(chars[0]);
			return new string(chars);
		}
	}
}
