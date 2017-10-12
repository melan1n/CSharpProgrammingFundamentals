using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05ArrayManipulator
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			var commandLine = Console.ReadLine().Split(' ').Select(str => str).ToArray();
			string command = commandLine[0];
			int index;
			int element;
			int[] elements;
			int positions;

			while (command != "print")
			{
				if (command == "add")
				{
					index = int.Parse(commandLine[1]);
					element = int.Parse(commandLine[2]);
					AddToList(numbers, index, element);
				}
				else if (command == "addMany")
				{
					index = int.Parse(commandLine[1]);
					elements = commandLine.Skip(2).Select(int.Parse).ToArray();
					AddManyToList(numbers, index, elements);
				}
				else if (command == "contains")
				{
					element = int.Parse(commandLine[1]);
					ListContains(numbers, element);
				}
				else if (command == "remove")
				{
					index = int.Parse(commandLine[1]);
					ListRemove(numbers, index);
				}
				else if (command == "shift")
				{
					positions = int.Parse(commandLine[1]);
					ListShift(numbers, positions);
				}
				else if (command == "sumPairs")
				{
					ListSumPairs(numbers);
				}
				commandLine = Console.ReadLine().Split(' ').Select(str => str).ToArray();
				command = commandLine[0];
			}
			if (command == "print")
			{
				Console.WriteLine($"[{string.Join(", ", numbers)}]");
			}
		}

		public static void ListSumPairs(List<int> numbers)
		{
			for (int i = 1; i < numbers.Count; i++)
			{
				numbers[i - 1] = numbers[i - 1] + numbers[i];
				ListRemove(numbers, i);
			}
		}

		public static void ListShift(List<int> numbers, long positions)
		{
			positions = positions % numbers.Count;
			var temp = numbers.Take((int)positions).ToArray();
			numbers.RemoveRange(0, (int)positions);
			numbers.AddRange(temp);
		}

		public static void ListRemove(List<int> numbers, int index)
		{
			numbers.RemoveAt(index);
		}

		public static void ListContains(List<int> numbers, int element)
		{
			//int index = -1;
			//index = numbers.FindIndex(x => x == element);
			//Console.WriteLine(index);
			Console.WriteLine(numbers.IndexOf(element));
		}

		public static void AddManyToList(List<int> numbers, int index, int[] elements)
		{
			numbers.InsertRange(index, elements);
			
		}

		public static void AddToList(List<int> numbers, int index, int element)
		{
			numbers.Insert(index, element);
		}
	}
}
