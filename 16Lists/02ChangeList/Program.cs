using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChangeList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			string[] commandLine = Console.ReadLine()
				.Split(' ')
				.Select(str => str)
				.ToArray();
			string command = commandLine[0];
			int element = 0;
			int position = 0;
			if (command == "Insert" || command == "Delete")
			{
				element = int.Parse(commandLine[1]);
			}
			if (command == "Insert")
			{
				position = int.Parse(commandLine[2]);
			}

			while (command != "Odd" && command != "Even")
			{
				if (command == "Delete")
				{
					numbers.RemoveAll(x => x == element);
				}
				else if (command == "Insert")
				{
					numbers.Insert(position, element);
				}
				commandLine = Console.ReadLine()
				.Split(' ')
				.Select(str => str)
				.ToArray();
				command = commandLine[0];
				if (command == "Insert" || command == "Delete")
				{
					element = int.Parse(commandLine[1]);
				}
				if (command == "Insert")
				{
					position = int.Parse(commandLine[2]);
				}
			}
			if (command == "Odd")
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					if (numbers[i] % 2 == 1)
					{
						Console.Write($"{numbers[i]} ");
					}
				}
			}
			else if (command == "Even")
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					if (numbers[i] % 2 == 0)
					{
						Console.Write($"{numbers[i]} ");
					}
				}
			}
			}
		}
	}

