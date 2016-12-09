using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge219
	{
		public static string Description()
		{
			return "List Manipulation: To-do List Part 1";
		}

		public static List<string> toDoList = new List<string>();
		public void Challenge_219()
		{
			var input = "";
			while(true)
			{
				Console.Clear();
				Console.WriteLine("exit or n to exit\nAddItem(Go to work);\nRemoveItem(Buy a new phone);\nViewList();");
				if(input.ToLower().Equals("viewlist();"))
					ViewList();
				input = Console.ReadLine();
				if(input.ToLower() == "n" || input.ToLower() == "exit")
					break;
				else if(input.ToLower().StartsWith("additem(") && input.ToLower().EndsWith(");"))
				{
					var split = input.ToLower().Split(new string[] { "additem(", ");" }, StringSplitOptions.RemoveEmptyEntries);
					AddItem(split[0]);
				}
				else if(input.ToLower().StartsWith("removeitem(") && input.ToLower().EndsWith(");"))
				{
					var split = input.ToLower().Split(new string[] { "removeitem(", ");" }, StringSplitOptions.RemoveEmptyEntries);
					RemoveItem(split[0]);
				}
			}
			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
			{
				Console.WriteLine("This is actually 219");
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/39ws1x/20150615_challenge_218_easy_todo_list_part_1/");
			}
		}

		public static void AddItem(string item)
		{
			if(!toDoList.Contains(item))
				toDoList.Add(item);
		}

		public static void RemoveItem(string item)
		{
			if(toDoList.Contains(item))
				toDoList.Remove(item);
		}

		public static void ViewList()
		{
			Console.WriteLine("\nList of stuff to do: ");
			foreach(var item in toDoList)
				Console.WriteLine(item);
		}
	}
}
