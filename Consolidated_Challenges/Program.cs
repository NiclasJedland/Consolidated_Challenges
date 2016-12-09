using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DISCLAIMER: I started doing the challenges to learn programming.\n");
			
			while(true)
			{
				string searchString = "";
				Console.WriteLine("Write the number of the challenge you wish to view IE (001 or 077).\nhelp for commands or quit to quit");

				string input = Console.ReadLine();
				input = input.ToLower().Trim();

				if(input == "exit" || input == "quit" || input == "q" || input == "n" || input == "no")
					break;
				if(input.Length > 0 && !char.IsDigit(input[0]))
				{
					switch(input.ToLower())
					{
						case "list":
						case "lst":
							//Loops through all available challenges and show them in ascending order.
							Console.WriteLine();
							ListChallenges().OrderBy(x => x.Key).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							Console.WriteLine("\n");
							break;
						case "listdescending":
						case "descending":
						case "listdes":
						case "lstdes":
							//Loops through all available challenges and show them in descending order.
							Console.WriteLine();
							ListChallenges().OrderByDescending(x => x.Key).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							Console.WriteLine("\n");
							break;
						case "missing":
						case "miss":
							//Loops through all available challenges, and find the missing ones
							Console.WriteLine();
							PrintMissingChallenges(ListChallenges(), "ascending");
							Console.WriteLine("\n");
							break;
						case "missdes":
						case "missingdes":
						case "missdesending":
						case "missingdesending":
							//Loops through all available challenges, and find the missing ones in descending order
							Console.WriteLine();
							PrintMissingChallenges(ListChallenges(), "descending");
							Console.WriteLine("\n");
							break;
						case "clear":
							Console.Clear();
							break;
						case "help":
						case "commands":
						case "command":
							Console.WriteLine("\nCommands:\nclear, quit, exit, a three digit number(IE: 001, 077)\nlist, listdescending, descending, listdes\nmissing, missingdescending, missingdes\nstring, math, other or search\n");
							break;
						case "math":
						case "maths":
							//Loops through all available challenges, and find all containing math
							ListChallenges().OrderBy(x => x.Key).Where(x => x.Value.ToLower().Contains("math")).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							break;
						case "string":
							//Loops through all available challenges, and find all containing string
							ListChallenges().OrderBy(x => x.Key).Where(x => x.Value.ToLower().Contains("string")).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							break;
						case "other":
						case "others":
							//Loops through all available challenges, and find all not containing string or math
							ListChallenges().OrderBy(x => x.Key).Where(x => !x.Value.ToLower().Contains("string")).Where(x => !x.Value.ToLower().Contains("math")).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							break;
						case "search":
							//Loops through all available challenges, and find all containing the word searched for
							Console.WriteLine("What do you wish to search for?");
							searchString = Console.ReadLine();
							if(searchString[0].ToString() == "-")
							{
								searchString = searchString.Substring(1, searchString.Length-1);
								ListChallenges().OrderBy(x => x.Key).Where(x => !x.Value.ToLower().Contains(searchString)).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							}
							else
								ListChallenges().OrderBy(x => x.Key).Where(x => x.Value.ToLower().Contains(searchString)).ToList().ForEach(x => { Console.WriteLine(x.Key + "\t" + x.Value); });
							break;
						default:
							Console.WriteLine("\nThe command '" + input + "' does not exist.\n");
							break;
					}
				}
				else if(input.Length > 0 && char.IsDigit(input[1]))
				{
					string myClass = "Challenge" + input;
					string myMethod = "Challenge_" + input;
					StartChallenge(myClass, myMethod, input);
				}
			}
		}

		public static void StartChallenge(string myClass, string myMethod, string challenge)
		{
			try
			{
				//Gets the challenge class and starts it unless an error is thrown
				Type type = Type.GetType("Consolidated_Challenges." + myClass);
				MethodInfo methodInfo = type.GetMethod(myMethod);
				Object obj = Activator.CreateInstance(type);
				Console.Clear();
				Console.WriteLine("Starting challenge " + challenge);
				methodInfo.Invoke(obj, null);
			}
			catch(Exception)
			{
				//The challenge number did not exist
				Console.WriteLine(myClass + " does not exist. type 'list' to see the list of all challenges\n");
			}
		}

		public static Dictionary<string, string> ListChallenges()
		{
			//Loops through all .cs files and find all in the "consolidated challenges" namespace and named "challenge"
			string nameSpace = "Consolidated_Challenges";
			var dict = new Dictionary<string, string>();
			var challengeNumber = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.IsClass && q.Namespace == nameSpace && q.Name.Substring(0, 3) == "Cha").Select(w => w).OrderBy(e => e.Name);

			foreach(var item in challengeNumber)
			{
				string description = "";
				try
				{
					var temp = item.InvokeMember("Description", BindingFlags.InvokeMethod, null, null, null);
					description = temp.ToString();
				}
				catch(Exception)
				{
					description = "No Description";
				}
				dict.Add(item.Name.Substring(item.Name.Length - 3, 3), description);
			}

			return dict.OrderBy(entry => entry.Key).ToDictionary(item => item.Key, item => item.Value);
		}

		public static void PrintMissingChallenges(Dictionary<string, string> allChallenges, string descending)
		{
			//print challenges that doesn't exist yet. 
			//First find all that exist, then get the highest number and loop through all numbers from one to the highest
			string highest = "";
			if(descending.ToLower() == "descending")
			{
				allChallenges = allChallenges.OrderByDescending(entry => entry.Key).ToDictionary(item => item.Key, item => item.Value);
				highest = allChallenges.First().Key.Substring(allChallenges.First().Key.Length - 3, 3);
				for(int i = int.Parse(highest); i > 1; i--)
				{
					if(allChallenges.Keys.Contains(i.ToString().PadLeft(3, '0')))
						continue;
					Console.Write(i.ToString().PadLeft(3, '0') + "\t");
				}
			}
			else
			{
				highest = allChallenges.Last().Key.Substring(allChallenges.Last().Key.Length - 3, 3);
				for(int i = 1; i < int.Parse(highest); i++)
				{
					if(allChallenges.Keys.Contains(i.ToString().PadLeft(3, '0')))
						continue;
					Console.Write(i.ToString().PadLeft(3, '0') + "\t");
				}
			}
		}
	}
}

/*
 			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("");
 */
