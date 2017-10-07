using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FoldAndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int k = arr.Length / 4;

			int[] lowerRow = new int[2 * k];
			for (int i = 0; i < 2*k; i++)
			{
				lowerRow[i] = arr[k + i];
			}

			int[] upperRow = new int[2 * k];
			for (int i = 0; i < k; i++)
			{
				upperRow[i] = arr[k - 1 - i];
			}
			for (int i = 0; i < k; i++)
			{
				upperRow[2*k-1-i] = arr[3 * k + i];
				
			}

			long[] sums = new long[2 * k];
			for (int i = 0; i < 2*k; i++)
			{
				sums[i] = upperRow[i] + lowerRow[i];
			}
			Console.WriteLine(String.Join(" ", sums));
		}
	}
}
