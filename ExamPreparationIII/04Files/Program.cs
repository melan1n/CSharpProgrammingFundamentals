
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Files
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, Dictionary<string, long>> files =
				new Dictionary<string, Dictionary<string, long>>();
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine()
					.Split(new char[] { '\\', ';'})
					.Select(x=>x)
					.ToArray();
				string root = input[0];
				long size = long.Parse(input[input.Length - 1]);
				string file = input[input.Length - 2];

				if (!files.ContainsKey(root))
				{
					files.Add(root, new Dictionary<string, long>() { {file, size } });
				}
				else if (files.ContainsKey(root) && files[root].ContainsKey(file))
				{
					files[root][file] = size;
				}
				else if (files.ContainsKey(root) && !files[root].ContainsKey(file))
				{
					files[root].Add(file, size);
				}
			}
			string[] query = Console.ReadLine()
				.Split(' ')
				.Select(x => x)
				.ToArray();
			string extension = query[0];
			string rootForSearch = query[2];

			if (!files.ContainsKey(rootForSearch))
			{
				Console.WriteLine("No");
			}
			else
			{
				int count = 0;
				foreach (var file in files[rootForSearch].OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
				{
					if (file.Key.EndsWith(extension))
					{
						Console.WriteLine($"{file.Key} - {file.Value} KB");
						count++;
					}
					
				}
				if (count == 0)
				{
					Console.WriteLine("No");
				}
			}
		}
	}
}
