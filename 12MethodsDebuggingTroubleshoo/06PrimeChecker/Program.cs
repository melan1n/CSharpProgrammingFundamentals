using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PrimeChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			long number = long.Parse(Console.ReadLine());
			Console.WriteLine(IsPrime(number));
		}

		static bool IsPrime(long number)
		{
			if (number == 0 || number == 1)
			{
				return false;
			}
			bool result = true;
			for (int i = 2; i <= (long)Math.Sqrt(number); i++)
			{
				if (number % (long)i == 0 && number != i)
				{
					result = false;
					break;
				}
			}
			return result;
		}
	}
}
