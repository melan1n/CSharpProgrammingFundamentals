using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01ConvertFromBase10ToBaseN
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ').ToArray();
			BigInteger baseSys = BigInteger.Parse(input[0]);
			string num = input[1];

			Console.WriteLine(ToStr(num, baseSys));
		}

		private static string ToStr(string num, BigInteger baseSys)
		{
			if (BigInteger.Parse(num) < baseSys)
			{
				return num;
			}
			else
			{
				return ToStr((BigInteger.Parse(num) / baseSys).ToString(), baseSys) + (BigInteger.Parse(num) % baseSys).ToString();
			}
		}
	}

}
