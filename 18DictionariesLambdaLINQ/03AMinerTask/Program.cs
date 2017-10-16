using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AMinerTask
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			Dictionary<string, int> book = new Dictionary<string, int>();
			int count = 1;
			string lastKey = string.Empty;
			while (line != "stop")
			{
				if (count%2 == 1)
				{
					if (book.ContainsKey(line) == false)
					{
						book.Add(line, 0);
					}
					lastKey = line;
				}
				else
				{
					book[lastKey] = book[lastKey] + int.Parse(line);
				}
				line = Console.ReadLine();
				count++;
			}
			foreach (var pair in book)
			{
				Console.WriteLine(String.Join(" -> ", pair.Key, pair.Value));
			}
		}
	}
}
