using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02ConvertFromBaseNToBase10
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(' ')
				.Select(s => s)
				.ToArray();
			string baseSyc = input[0];
			BigInteger num = BigInteger.Parse(input[1]);

			Console.WriteLine(ToStr(num, baseSyc));

		}

		private static string ToStr(BigInteger num, string baseSyc)
		{
			BigInteger result = 0;
			for (int i = num.ToString().Length-1; i >= 0; i--)
			{
				BigInteger currDigit = (BigInteger)(char.GetNumericValue(num.ToString()[i]));
				result = result +  BigInteger.Multiply(currDigit, BigInteger.Pow(BigInteger.Parse(baseSyc), (num.ToString().Length - i - 1)));
			}
			return result.ToString();

		}
	}
}
