using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArrayManipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> inputList = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			while (true)
			{
				string commandLine = Console.ReadLine();
				string[] tokens = commandLine
					.Split(' ')
					.Select(x => x)
					.ToArray();
				if (commandLine == "end")
				{
					break;
				}
				else if (tokens[0] == "exchange")
				{
					int index = int.Parse(tokens[1]);
					if (index < 0 || index >= inputList.Count)
					{
						Console.WriteLine("Invalid index");
					}
					else
					{
						inputList = ExchangeAtIndex(inputList, index);
					}
				}
				else if (tokens[0] == "max")
				{
					if (tokens[1] == "even")
					{
						MaxEven(inputList); 

					}
					else if (tokens[1] == "odd")
					{
						MaxOdd(inputList);

					}
				}
				else if (tokens[0] == "min")
				{
					if (tokens[1] == "even")
					{
						MinEven(inputList);

					}
					else if (tokens[1] == "odd")
					{
						MinOdd(inputList);

					}
				}
				else if (tokens[0] == "first")
				{
					int count = int.Parse(tokens[1]);
					if (count > inputList.Count)
					{
						Console.WriteLine("Invalid count");
					}
					else if (tokens[2] == "even")
					{
						FirstCountEven(inputList, count);
	
					}
					else if (tokens[2] == "odd")
					{
						FirstCountOdd(inputList, count);
					}
				}
				else if (tokens[0] == "last")
				{
					int count = int.Parse(tokens[1]);
					if (count > inputList.Count)
					{
						Console.WriteLine("Invalid count");
					}
					else if (tokens[2] == "even")
					{
						LastCountEven(inputList, count);

					}
					else if (tokens[2] == "odd")
					{
						LastCountOdd(inputList, count);

					}
				}
			}
			Console.WriteLine($"[" + string.Join(", ", inputList) + $"]");
		}

		private static void LastCountOdd(List<int> list, int count)
		{
			List<int> result = new List<int>();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i] % 2 == 1)
				{
					result.Add(list[i]);
				}
				if (result.Count == count)
				{
					List<int> reversedResult = result.Select(x=>x).Reverse().ToList();
					Console.WriteLine($"[{string.Join(", ", reversedResult)}]");
					break;
				}
			}
			if (result.Count > 0 && result.Count < count)
			{
				List<int> reversedResult = result.Select(x => x).Reverse().ToList();
				Console.WriteLine($"[{string.Join(", ", reversedResult)}]");

			}
			else if (result.Count == 0)
			{
				Console.WriteLine($"[]");
			}
		}

		private static void LastCountEven(List<int> list, int count)
		{
			List<int> result = new List<int>();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i] % 2 == 0)
				{
					result.Add(list[i]);
				}
				if (result.Count == count)
				{
					List<int> reversedResult = result.Select(x => x).Reverse().ToList();
					Console.WriteLine($"[{string.Join(", ", reversedResult)}]");
					break;
				}
			}
			if (result.Count > 0 && result.Count < count)
			{
				List<int> reversedResult = result.Select(x => x).Reverse().ToList();
				Console.WriteLine($"[{string.Join(", ", reversedResult)}]");

			}
			else if (result.Count == 0)
			{
				Console.WriteLine($"[]");
			}
		}

		private static void FirstCountOdd(List<int> list, int count)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] % 2 == 1)
				{
					result.Add(list[i]);
				}
				if (result.Count == count)
				{
					Console.WriteLine($"[{string.Join(", ", result)}]");
					break;
				}
			}
			if (result.Count > 0 && result.Count < count)
			{
				Console.WriteLine($"[{string.Join(", ", result)}]");

			}
			else if (result.Count == 0)
			{
				Console.WriteLine($"[]");
			}
		}

		private static void FirstCountEven(List<int> list, int count)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] % 2 == 0)
				{
					result.Add(list[i]);
				}
				if (result.Count == count)
				{
					Console.WriteLine($"[{string.Join(", ", result)}]");
					break;
				}
			}
			if (result.Count > 0 && result.Count < count)
			{
				Console.WriteLine($"[{string.Join(", ", result)}]");

			}
			else if (result.Count == 0)
			{
				Console.WriteLine($"[]");
			}
		}

		private static void MinOdd(List<int> list)
		{
			int result = -1;
			int min = int.MaxValue;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] % 2 == 1 && list[i] <= min)
				{
					result = i;
					min = list[i];
				}
			}
			if (result == -1)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine(result);
			}
		}

		private static void MinEven(List<int> list)
		{
			int result = -1;
			int min = int.MaxValue;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] % 2 == 0 && list[i] <= min)
				{
					result = i;
					min = list[i];
				}
			}
			if (result == -1)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine(result);
			}
		}

		private static void MaxOdd(List<int> list)
		{
			int result = -1;
			int max = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] % 2 == 1 && list[i] >= max)
				{
					result = i;
					max = list[i];
				}
			}
			if (result == -1)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine(result);
			}
		}

		private static void MaxEven(List<int> list)
		{
			int result = -1;
			int max = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] % 2 == 0 && list[i] >= max)
				{
					result = i;
					max = list[i];
				}
			}
			if (result == -1)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine(result);
			}
		}

		private static List<int> ExchangeAtIndex(List<int> list, int index)
		{
			List<int> result = new List<int>();
			
			for (int i = index+1; i < list.Count; i++)
			{
				result.Add(list[i]);
			}
			for (int i = 0; i <= index; i++)
			{
				result.Add(list[i]);

			}

			return result;
		}
	}
}
