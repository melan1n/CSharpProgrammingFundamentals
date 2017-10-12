using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ArrayManipulatorNew
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			var commandLine = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(str => str)
				.ToArray();
			
			while (commandLine[0] != "print")
			{
				if (commandLine[0] == "add")
				{
					numbers.Insert(int.Parse(commandLine[1]), int.Parse(commandLine[2]));
				}
				else if (commandLine[0] == "addMany")
				{
					numbers.InsertRange(int.Parse(commandLine[1]), commandLine.Skip(2).Select(int.Parse).ToArray());
				}
				else if (commandLine[0] == "contains")
				{
					Console.WriteLine(numbers.IndexOf(int.Parse(commandLine[1])));
				}
				else if (commandLine[0] == "remove")
				{
					numbers.RemoveAt(int.Parse(commandLine[1]));
				}
				else if (commandLine[0] == "shift")
				{
					int positions = int.Parse(commandLine[1]) % numbers.Count;
					var temp = numbers.Take(positions).ToArray();
					numbers.RemoveRange(0, positions);
					numbers.AddRange(temp);
				}
				else if (commandLine[0] == "sumPairs")
				{
					for (int i = 1; i < numbers.Count; i++)
					{
						numbers[i - 1] = numbers[i - 1] + numbers[i];
						numbers.RemoveAt(i);
					}
				}
				commandLine = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(str => str)
					.ToArray();
			}
			if (commandLine[0] == "print")
			{
				Console.Write($"[");
				for (int i = 0; i<numbers.Count-1; i++)
				{
					Console.Write($"{numbers[i]}, ");
				}
				Console.Write($"{numbers[numbers.Count-1]}]");

			}
		}
	}
}
