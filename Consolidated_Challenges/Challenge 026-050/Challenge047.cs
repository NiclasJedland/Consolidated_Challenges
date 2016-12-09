using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge047
	{
		public static string Description()
		{
			return "String Manipulation: Decipher";
		}

		public void Challenge_047()
		{
			Console.WriteLine("Original Text:\nSpzalu - zayhunl dvtlu sfpun pu wvukz kpzaypibapun zdvykz pz uv ihzpz mvy h "
						+ "zfzalt vm nvclyutlua.  Zbwyltl leljbapcl wvdly klypclz myvt h thukhal myvt aol "
						+ "thzzlz, uva myvt zvtl mhyjpjhs hxbhapj jlyltvuf. Fvb jhu'a lewlja av dplsk "
						+ "zbwyltl leljbapcl wvdly qbza 'jhbzl zvtl dhalyf ahya aoyld h zdvyk ha fvb! P "
						+ "tlhu, pm P dlua hyvbuk zhfpu' P dhz hu ltwlylyvy qbza iljhbzl zvtl tvpzalulk "
						+ "ipua ohk sviilk h zjptpahy ha tl aolf'k wba tl hdhf!... Ho, huk uvd dl zll aol "
						+ "cpvslujl puolylua pu aol zfzalt! Jvtl zll aol cpvslujl puolylua pu aol zfzalt! "
						+ "Olsw! Olsw! P't ilpun ylwylzzlk!\n\n");

			string text = "Spzalu - zayhunl dvtlu sfpun pu wvukz kpzaypibapun zdvykz pz uv ihzpz mvy h "
						+ "zfzalt vm nvclyutlua.  Zbwyltl leljbapcl wvdly klypclz myvt h thukhal myvt aol "
						+ "thzzlz, uva myvt zvtl mhyjpjhs hxbhapj jlyltvuf. Fvb jhu'a lewlja av dplsk "
						+ "zbwyltl leljbapcl wvdly qbza 'jhbzl zvtl dhalyf ahya aoyld h zdvyk ha fvb! P "
						+ "tlhu, pm P dlua hyvbuk zhfpu' P dhz hu ltwlylyvy qbza iljhbzl zvtl tvpzalulk "
						+ "ipua ohk sviilk h zjptpahy ha tl aolf'k wba tl hdhf!... Ho, huk uvd dl zll aol "
						+ "cpvslujl puolylua pu aol zfzalt! Jvtl zll aol cpvslujl puolylua pu aol zfzalt! "
						+ "Olsw! Olsw! P't ilpun ylwylzzlk!";

			Console.WriteLine(Decipher(text, 19));
			Console.WriteLine("\n");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/t33vi/522012_challenge_47_easy/");
		}

		public static string Decipher(string text, int shift)
		{
			char[] output = text.ToLower().ToCharArray();

			for(int i = 0; i < text.Length; i++)
			{
				char letter = output[i];

				if(Char.IsLetter(letter))
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
					output[i] = letter;

				}
			}

			return new string(output);
		}
	}
}
