using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07BombNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			int[] arguments = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int bomb = arguments[0];
			int range = arguments[1];

			while (numbers.IndexOf(bomb) != -1)
			{
				int startIndex = numbers.IndexOf(bomb) - range >= 0 ? numbers.IndexOf(bomb) - range : 0;
				int removeCount = startIndex + 2 * range + 1 > numbers.Count ? numbers.Count - startIndex : 2 * range + 1;
				numbers.RemoveRange(startIndex, removeCount);
			}
			Console.WriteLine(numbers.Sum());
		}
	}
}
