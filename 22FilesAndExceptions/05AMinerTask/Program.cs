using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05AMinerTask
{
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input.txt",
				"Gold\r\n155\r\nSilver\r\n10\r\nCopper\r\n17\r\nstop");
			string[] lines = File.ReadAllLines("input.txt");
			Dictionary<string, int> book = new Dictionary<string, int>();
			int count = 1;
			string lastKey = string.Empty;
			for (int i = 0; i < lines.Length-1; i++)
			{
				if (count % 2 == 1)
				{
					if (book.ContainsKey(lines[i]) == false)
					{
						book.Add(lines[i], 0);
					}
					lastKey = lines[i];
				}
				else
				{
					book[lastKey] = book[lastKey] + int.Parse(lines[i]);
				}
				
				count++;
			}
			foreach (var pair in book)
			{
				File.AppendAllText("output.txt", String.Join(" -> ", pair.Key, pair.Value) + "\r\n");
			}
		}
	}
}
