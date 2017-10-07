using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RotateTheSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int k = int.Parse(Console.ReadLine());
			long[] sum = new long[arrInt.Length];

			for (int i = 1; i <= k; i++)
			{
				RotateArray(arrInt);
				for (int j = 0; j < sum.Length; j++)
				{
					sum[j] += arrInt[j]; 
				}
			}
			Console.WriteLine(string.Join(" ", sum));
		}

		static void RotateArray(int[] arrInt)
		{
			int temp = arrInt[arrInt.Length - 1];
			for (int i = arrInt.Length - 1; i > 0 ; i--)
			{
				arrInt[i] = arrInt[i - 1];
			}
			arrInt[0] = temp;
		}
	}
}
