using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SumAdjacentEqualNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<decimal> numbers = Console.ReadLine()
				.Split(' ')
				.Select(decimal.Parse)
				.ToList();
			for (int i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] == numbers[i-1])
				{
					decimal sumOfPair = numbers[i] * 2;
					numbers.RemoveRange(i - 1, 2);
					numbers.Insert(i-1, sumOfPair);
					i = 0;
				}
			}
			Console.WriteLine(String.Join(" ", numbers));
		
		}
	}
}
