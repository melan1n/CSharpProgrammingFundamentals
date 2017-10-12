using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CountRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> numbers = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToList();
			SortedDictionary <double, int> result = new SortedDictionary<double, int>();
			foreach (double number in numbers)
			{
				if (result.ContainsKey(number) == true)
				{
					result[number]++;
				}
				else
				{
					result.Add(number, 1);
				}
			}
			foreach (var pair in result)
			{
				Console.WriteLine($"{pair.Key} -> {pair.Value}");
			}
		}
	}
}
