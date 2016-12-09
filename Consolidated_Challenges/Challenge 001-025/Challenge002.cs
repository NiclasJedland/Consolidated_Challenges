using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge002
	{
		public static string Description()
		{
			return "Math Problems: F=ma";
		}

		public void Challenge_002()
		{
			while(true)
			{
				Console.WriteLine("Would you like to find Force (F), Mass (m) or Acceleration (a)?\nOr 'quit' to quit.");
				string input = Console.ReadLine();

				if(input.ToLower() == "exit" || input.ToLower() == "quit" || input.ToLower() == "q")
					break;

				if(input.ToLower() == "f" || input.ToLower() == "force")
				{
					Console.WriteLine("What is the Mass (m)?");
					var Mass = Console.ReadLine();
					float mass = float.Parse(Mass);

					Console.WriteLine("What is the Acceleration (a)?");
					var Acc = Console.ReadLine();
					float acc = float.Parse(Acc);

					Console.WriteLine("The force is: " + FindF(mass, acc));
				}
				else if(input.ToLower() == "m" || input.ToLower() == "mass")
				{
					Console.WriteLine("What is the Force (F)?");
					var Force = Console.ReadLine();
					float force = float.Parse(Force);

					Console.WriteLine("What is the Acceleration (a)?");
					var Acc = Console.ReadLine();
					float acc = float.Parse(Acc);

					Console.WriteLine("The mass is: " + FindM(force, acc));
				}
				else if(input.ToLower() == "a" || input.ToLower() == "acc" || input.ToLower() == "acceleration")
				{
					Console.WriteLine("What is the Force (F)?");
					var Force = Console.ReadLine();
					float force = float.Parse(Force);

					Console.WriteLine("What is the Mass (m)?");
					var Mass = Console.ReadLine();
					float mass = float.Parse(Mass);

					Console.WriteLine("The acceleration is: " + FindA(force, mass));
				}
				else
				{
					Console.WriteLine("Please format as 'm', 'M', 'Mass' or 'mass', or 'quit' to quit");
				}
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pjbj8/easy_challenge_2/");
		}

		static float FindF(float m, float a)
		{
			float f = m * a;
			return f;
		}

		static float FindM(float f, float a)
		{
			float m = f / a;
			return m;
		}

		static float FindA(float f, float m)
		{
			float a = f / m;
			return a;
		}
	}
}
