using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumBigNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();

			if (a.Length <= b.Length)
			{
				Console.WriteLine(SumBigNums(a, b));
			}
			else
			{
				Console.WriteLine(SumBigNums(b,a));
			}
		}

		private static string SumBigNums(string a, string b)
		{
			string sum = "";
			int indexDiff = b.Length - a.Length;
			int digitSum = 0;
			int accumulator = 0;
			for (int i = b.Length - 1; i >= 0; i--)
			{
				if (i >= indexDiff)
				{
					digitSum = (int)char.GetNumericValue(a[i - indexDiff]) + (int)char.GetNumericValue(b[i]) + accumulator;
					accumulator = 0;
					sum += (digitSum % 10).ToString();
					accumulator = digitSum / 10;
				}
				else
				{
					digitSum = (int)char.GetNumericValue(b[i]) + accumulator;
					accumulator = 0;
					sum += (digitSum % 10).ToString();
					accumulator = digitSum / 10;
				}
				
			}
			if (accumulator > 0)
			{
				sum += accumulator;
			}
			char[] result = sum.ToCharArray();
			Array.Reverse(result);
			return new string (result);
		}
	}
}
