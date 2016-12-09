using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge271
	{
		public static string Description()
		{
			return "Math Problem: Critical Hits";
		}

		static Random rnd = new Random();
		public void Challenge_271()
		{
			while(true)
			{
				int heroMaxHealth = 10;
				int heroCurrentHealth = heroMaxHealth;
				int numberOfAttackDice = 2;
				int numberOfDiceSides = 0;

				int monsterAttack = 2;
				int monsterMaxHealth = rnd.Next(1, 1000);
				int monsterCurrentHealth = monsterMaxHealth;

				int sum = 0;

				Console.WriteLine("How many sides do the die have? Minimum 1.");
				var input = Console.ReadLine();
				if(int.TryParse(input, out numberOfDiceSides))
				{
					Console.WriteLine("The monster has {0} HP.\nProbability of oneshotting the monster is {1}%", monsterCurrentHealth, Math.Round(MinimumScoreProbability(numberOfDiceSides, monsterCurrentHealth, numberOfAttackDice) * 100), 10);

					while(monsterCurrentHealth > 0)
					{
						if(heroCurrentHealth <= 0)
							break;
						for(int i = 0; i < numberOfAttackDice; i++)
						{
							if(monsterCurrentHealth <= 0)
								break;
							int roll = rnd.Next(1, numberOfDiceSides + 1);
							if(roll == numberOfDiceSides)
							{
								sum += roll;
								monsterCurrentHealth -= roll;
								numberOfAttackDice++;
							}
							else
							{
								sum += roll;
								monsterCurrentHealth -= roll;
							}
						}
						heroCurrentHealth -= monsterAttack;
					}

					Console.WriteLine("You rolled: {0} with total of {1} dice.", sum, numberOfAttackDice);
					if(heroCurrentHealth <= 0)
						Console.WriteLine("You died. The monster have {0}HP left.", monsterCurrentHealth);
					else
						Console.WriteLine("You won. You have {0}/{1}HP left. The monster had {2} HP.", heroCurrentHealth, heroMaxHealth, monsterMaxHealth);

					Console.WriteLine("Play again?");
					input = Console.ReadLine();
					if(input.ToLower() == "n" || input.ToLower() == "no")
						break;
				}
				else
					Console.WriteLine("Number of sides must be a whole number.");
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/4nvrnx/20160613_challenge_271_easy_critical_hit/");
		}

		static double MinimumScoreProbability(int numberOfDiceSides, int monsterHealth, int numberOfDice)
		{
			double probability = 1;

			while(monsterHealth > numberOfDiceSides)
			{
				probability *= (1.0 / numberOfDiceSides) * numberOfDice;
				monsterHealth -= numberOfDiceSides;
			}

			if(monsterHealth > 0)
				probability *= (1.0 + numberOfDiceSides - monsterHealth) / numberOfDiceSides;

			return probability > 1 ? 1 : probability;
		}

	}
}
