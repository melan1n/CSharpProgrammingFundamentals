using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _02CommandInterpreter
{
	static void Main()
	{
		List<string> items = ReadInput();

		while (true)
		{
			string commandLine = Console.ReadLine();
			if (commandLine == "end")
			{
				break;
			}
			ProcessCommand(items, commandLine);
			Console.WriteLine($"[" + string.Join(", ", items) + $"]");
		}
	}
	static void ProcessCommand(List<string> items, string commandLine)
	{
		var cmdTokens = commandLine.Split(' ');
		var cmdName = cmdTokens[0];
		switch (cmdName)
		{
			case "reverse":
				ReverseList(items, cmdTokens);
				break;
			case "sort":
				SortList(items, cmdTokens);
				break;
			case "rollLeft":
				RollLeftList(items, cmdTokens);
				break;
			case "rollRight":
				RollRightList(items, cmdTokens);
				break;
			default:
				Console.WriteLine("Invalid Command");
				break;
		}
	}

	static void RollRightList(List<string> items, string[] cmdTokens)
	{
		;
	}

	static void RollLeftList(List<string> items, string[] cmdTokens)
	{
		int count = int.Parse(cmdTokens[1]);
		if (count > 0)
		{
			RollListList(items, count);
		}
		else
		{
			Console.WriteLine($"Invalid input parameters.");
		}
	}

	static void RollListList(List<string> items, int count)
	{
		count = count % items.Count;
		var result = new List<string>(items.Count);
		for (int i = 0; i < items.Count; i++)
		{
			var newPos = (i + count) % items.Count;
			if (newPos >= items.Count)
			{
				newPos -= items.Count;
			}
			result[newPos] = items[i];
		}
		var index = 0;
		foreach (var item in result.ToList())
		{
			items[index] = item;
			index++;
		}
	}

	static void SortList(List<string> items, string[] cmdTokens)
	{
		int start = int.Parse(cmdTokens[2]);
		int count = int.Parse(cmdTokens[4]);
		if (IsValidRange(items, start, count))
		{
			SortList(items, start, count);
		}
		else
		{
			Console.WriteLine($"Invalid input parameters.");
		}
	}

	static void SortList(List<string> items, int start, int count)
	{
		var leftList = items.Take(start);
		var middleList = items.Skip(start).Take(count).OrderBy(x => x);
		var rightList = items.Skip(start + count);
		var allItems = leftList.Concat(middleList).Concat(rightList);

		var index = 0;
		foreach (var item in allItems.ToList())
		{
			items[index] = item;
			index++;
		}
	}

	static bool IsValidRange(List<string> items, int start, int count)
	{
		if (start < 0)
		{
			return false;
		}
		if (count <= 0)
		{
			return false;
		}
		if (start + count - 1 >= items.Count)
		{
			return false;
		}
		return true;
	}

	static void ReverseList(List<string> items, string[] cmdTokens)
	{
		int start = int.Parse(cmdTokens[2]);
		int count = int.Parse(cmdTokens[4]);
		if (IsValidRange(items, start, count))
		{
			ReverseList(items, start, count);
		}
		else
		{
			Console.WriteLine($"Invalid input parameters.");
		}
		
	}

	private static void ReverseList(List<string> items, int start, int count)
	{
		var endIndex = start + count - 1;

		while (start<endIndex)
		{
			var oldValue = items[start];
			items[start] = items[endIndex];
			items[endIndex] = oldValue;
			start++;
			endIndex--;
		}
	}

	static List<string> ReadInput()
	{
		List<string> input = Console.ReadLine()
			.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(x => x)
			.ToList();
		return input;
	}
}


