using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SearchForANumber
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			int[] input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			int countInclude = input[0];
			int countDelete = input[1];
			int search = input[2];

			List<int> result = numbers.Take(countInclude).ToList();
			List<int> resultNew = result.Skip(countDelete).ToList();
			if (resultNew.Exists(x => x == search) == true)
			{
				Console.WriteLine("YES!");
			}
			else
			{
				Console.WriteLine("NO!");
			}

		}
	}
}
