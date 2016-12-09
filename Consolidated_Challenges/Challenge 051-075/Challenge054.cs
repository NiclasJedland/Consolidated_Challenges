using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge054
	{
		public static string Description()
		{
			return "String Manipulation: Matrix Cipher";
		}
		
		public void Challenge_054()
		{
			Console.WriteLine("Original String: 'The cake is a lie!'");
			Console.WriteLine(Encode("The cake is a lie!", 3));
			Console.WriteLine("\n");

			//int bruteKey = BruteForceCracker("I_rso_wo", "It_seems");

			//Console.WriteLine(Decode("I_rso_wotTe,taef_h__hl__socaeihtemonraaheamd_svemsp_l_ems_ayiN___Anofeadt.yueo_oh_..__leaA_.iaastnY.snw__do__d_nyeuhl_foor_eiaotushlvrr.'oapee.avnv_d__he,ey_gOf___oiunrbpaunieeer_r_l_geos_ctoingoloyfq_rcam__ilainpotlimadufhjv_llt_emiw_aevsdnrsdriengieysr_p_tc_,tlfteuc_uitwrrawavzo_irhlez_ftrelszloyyry_bir__e_huv_no_eadeauuyvsbs_mtoe_l.rb_urat_eeh_y_pOsreg_fjnp,rocucee___otn_cpgbmujltaayprgiayr_uepfb_btt,velyahe_s,eogeraq__ue__ncysr.hcdzoo__ar_duftTcioi'tahkmnarwxeeeegeae_r__j", bruteKey));

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/tux8f/5192012_challenge_54_easy/");
		}

		public static string Encode(string input, int key)
		{
			if(input == "" || key <= 0)
				return string.Empty;
			int height = (input.Length % key == 0) ? (input.Length / key) : ((input.Length / key) + 1);
			char?[,] matrix = new char?[height, key];
			int ptr = 0;

			for(int i = 0; i < height; i++)
				for(int j = 0; j < key && ptr < input.Length; j++, ptr++)
					matrix[i, j] = input[ptr];

			StringBuilder sb = new StringBuilder();
			for(int i = 0; i < key; i++)
				for(int j = 0; j < height; j++)
					sb.Append(matrix[j, i] ?? RandomLetter());
			return sb.ToString();
		}

		public static string Decode(string input, int key)
		{
			if(input == "" || key <= 0)
				return string.Empty;
			int width = (input.Length % key == 0) ? (input.Length / key) : ((input.Length / key) + 1);
			char[,] matrix = new char[key, width];
			int ptr = 0;

			for(int i = 0; i < key; i++)
				for(int j = 0; j < width && ptr < input.Length; j++, ptr++)
					matrix[i, j] = input[ptr];

			StringBuilder sb = new StringBuilder();
			for(int i = 0; i < width; i++)
				for(int j = 0; j < key; j++)
					sb.Append(matrix[j, i]);
			return sb.ToString();
		}
		//Unfinished
		public static int BruteForceCracker(string input, string known)
		{
			string decoded;
			int key = 1;
			while(true)
			{
				decoded = Decode(input, key);
				if(decoded.Substring(0, known.Length) == known)
					return key;
				if(key == input.Length)
					return -1;
				key++;
			}
		}

		private static Random random = new Random();
		private static char RandomLetter()
		{
			return (char)random.Next(97, 123);
		}
	}
}
