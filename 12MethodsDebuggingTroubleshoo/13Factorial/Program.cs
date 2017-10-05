using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			short n = short.Parse(Console.ReadLine());
			Console.WriteLine(Factorial(n));
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
