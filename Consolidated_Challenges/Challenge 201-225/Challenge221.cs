using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge221
	{
		public static string Description()
		{
			return "String Manipulation: Word Snake";
		}

		static Random rnd = new Random();
		public void Challenge_221()
		{
			string input1 = "SHENANIGANS SALTY YOUNGSTER ROUND DOUBLET TERABYTE ESSENCE";
			string input2 = "DELOREAN NEUTER RAMSHACKLE EAR RUMP PALINDROME EXEMPLARY YARD";
			string input3 = "CAN NINCOMPOOP PANTS SCRIMSHAW WASTELAND DIRK KOMBAT TEMP PLUNGE ESTER REGRET TOMBOY";
			string input4 = "NICKEL LEDERHOSEN NARCOTRAFFICANTE EAT TO OATS SOUP PAST TELEMARKETER RUST THINGAMAJIG GROSS SALTPETER REISSUE ELEPHANTITIS";

			Snake(input1);
			Snake(input2);
			Snake(input3);
			Snake(input4);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/3bi5na/20150629_challenge_221_easy_word_snake/");
		}

		public static void Snake(string inputText)
		{
			var count = inputText.Count(f => f == ' ') + 1;
			var words = inputText.Split();

			var row = 0;
			var column = 0;
			var nextDirection = "right";
			var previousDirection = "up";
			var skipNextLetter = false;

			var outputWords = new List<string>();

			foreach(var letter in inputText)
			{
				if(char.IsWhiteSpace(letter))
				{
					switch(nextDirection)
					{
						case "right":
							nextDirection = previousDirection == "down" ? "up" : "down";
							previousDirection = "right";
							break;
						case "down":
							nextDirection = "right";
							previousDirection = "down";
							break;
						case "up":
							nextDirection = "right";
							previousDirection = "up";
							break;
					}
					skipNextLetter = true;
				}
				else
				{
					if(skipNextLetter == false)
					{
						switch(nextDirection)
						{
							case "right":
								column++;
								break;
							case "down":
								row++;
								break;
							case "up":
								row--;
								break;
						}

						if(outputWords.Count <= row + 1)
							outputWords.Add("");

						while(outputWords[row].Length != column)
							outputWords[row] += " ";

						outputWords[row] += letter;
					}
					skipNextLetter = false;
				}
			}
			foreach(var outputWord in outputWords)
				Console.WriteLine(outputWord);
		}
	}
}
