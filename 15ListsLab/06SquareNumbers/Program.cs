using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SquareNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			List<int> squareNumbers = new List<int>();
			foreach (int number in numbers)
			{
				if (Math.Sqrt((double)number)%1 == 0.0)
				{
					squareNumbers.Add(number);
				}
			}
			squareNumbers.Sort();
			squareNumbers.Reverse();
			Console.WriteLine(string.Join(" ", squareNumbers));
		}
	}
}
