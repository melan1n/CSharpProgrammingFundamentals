using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CountNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			int[] numbersOccurrences = new int[1001];
			foreach (int number in numbers)
			{
				numbersOccurrences[number]++;
			}
			for (int i = 0; i < 1001; i++)
			{
				if (numbersOccurrences[i] != 0)
				{
					Console.WriteLine($"{i} -> {numbersOccurrences[i]}");
				}
			}
		}
	}
}
