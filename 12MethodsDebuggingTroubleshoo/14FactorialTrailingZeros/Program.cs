using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14FactorialTrailingZeros
{
	class Program
	{
		static void Main(string[] args)
		{
			short n = short.Parse(Console.ReadLine());
			Console.WriteLine(TrailingZeros(Factorial(n)));
		}

		static int TrailingZeros(BigInteger number)
		{
			int zeroCount = 0;
			while (number >= 1)
			{
				BigInteger currentNum = number % 10;
				if (currentNum == 0)
				{
					zeroCount++;
				}
				else
				{
					break;
				}
				number = number / 10;
			}
			return zeroCount;
		}

		static BigInteger Factorial(short n)
		{
			BigInteger factorial = 1;
			for (BigInteger i = 1; i <= n; i++)
			{
				factorial = factorial * i;
			}
			return factorial;
		}
	}
}
