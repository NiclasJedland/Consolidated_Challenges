using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge045
	{
		public static string Description()
		{
			return "String Manipulation: Chessboard";
		}

		public void Challenge_045()
		{	
			while(true)
			{
				Console.WriteLine("How many rows, columns, size of squares. Space between each numbers.");
				string str = Console.ReadLine();
				string[] strarr = str.Split(' ');
				int rows = int.Parse(strarr[0]);
				int cols = int.Parse(strarr[1]);
				int size = int.Parse(strarr[2]);

				Chessboard Board = new Chessboard(rows, cols, size);

				Board.DrawBoard();

				Console.WriteLine("Play again?");
				string playagain = Console.ReadLine();
				if(playagain.ToLower() == "n" || playagain.ToLower() == "no")
					break;
			}

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/sv6lw/4272012_challenge_45_easy/");
		}
	}

	public class Chessboard
	{
		private int rows;
		private int cols;
		private int size;
		private int border;

		public Chessboard(int rows, int cols, int size)
		{
			this.rows = rows;
			this.cols = cols;
			this.size = size;
			this.border = cols * size + cols;
		}

		public void DrawBoard()
		{
			for(int i = 0; i < rows; i++)
			{
				DrawLine();
				DrawRow(i % 2);
			}
			DrawLine();
		}

		public void DrawRow(int offset)
		{
			for(int i = 0; i < size; i++)
			{
				int position = offset;
				for(int j = 0; j < cols; j++)
				{
					Console.Write("*");
					for(int k = 0; k < size; k++)
						if(position % 2 == 0)
							Console.Write("#");
						else
							Console.Write(" ");
					position++;
				}
				Console.Write("*");
				Console.WriteLine();
			}
		}

		private void DrawLine()
		{
			for(int i = 0; i < (cols * size + cols + 1); i++)
				Console.Write("*");
			Console.WriteLine();
		}
	}
}
