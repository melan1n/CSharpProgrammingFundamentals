using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MultiplyBigNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = Console.ReadLine();
			char b = (char)Console.Read();

			if (char.GetNumericValue(b) == 0)
			{
				Console.WriteLine("0");
			}
			else
			{
				Console.WriteLine(Multiply(a, b));
			}
		}

		private static string Multiply(string a, char b)
		{
			string sum = "";
			int digitSum = 0;
			int accumulator = 0;

			for (int i = a.Length - 1; i >= 0; i--)
			{
				digitSum = (int)char.GetNumericValue(a[i]) * (int)char.GetNumericValue(b) + accumulator;
				accumulator = 0;
				sum += (digitSum % 10).ToString();
				accumulator = digitSum / 10;

			}
			if (accumulator > 0)
			{
				sum += accumulator;
			}
			char[] result = sum.ToCharArray();
			Array.Reverse(result);
			return new string(result).TrimStart('0');
		}
	}
}
