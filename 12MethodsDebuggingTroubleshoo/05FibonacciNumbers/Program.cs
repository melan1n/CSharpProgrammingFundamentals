using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FibonacciNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(Fib(n));
		}

		private static int Fib(int n)
		{
			int result = 1;
			int twoBeforeResult = 1;
			int beforeResult = 1;
			for (int i = 2; i <= n; i++)
			{
				result = twoBeforeResult + beforeResult;
				twoBeforeResult = beforeResult;
				beforeResult = result;
			}
			return result;
		}
	}
}
