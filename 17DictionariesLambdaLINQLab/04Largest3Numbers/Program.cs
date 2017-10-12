using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Largest3Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			//LONGER SOLUTION
			//List<double> numbers = Console.ReadLine()
			//	.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
			//	.Select(double.Parse)
			//	.ToList();
			//numbers = numbers.OrderByDescending(x => x).Take(3).ToList();
			//Console.WriteLine(String.Join(" ", numbers));
			Console.WriteLine(String.Join(" ", Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToList()
				.OrderByDescending(x => x)
				.Take(3)
				.ToList()));
		}
	}
}




