using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12TestNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int maxSumBoundary = int.Parse(Console.ReadLine());
			int maxSum = 0;
			int comboCount = 0;

			for (int i = n; i >= 1; i--)
			{
				for (int j = 1; j <= m; j++)
				{
					int tempSum = 3 * i * j;
					maxSum = maxSum + tempSum;
					comboCount++;

					if (maxSum >= maxSumBoundary)
					{
						Console.WriteLine($"{comboCount} combinations");
						Console.WriteLine($"Sum: {maxSum} >= {maxSumBoundary}");
						break;
					}
				}
				if (maxSum >= maxSumBoundary)
				{
					break;
				}
			}
			if (maxSum < maxSumBoundary)
			{
				Console.WriteLine($"{comboCount} combinations");
				Console.WriteLine($"Sum: {maxSum}");
			}
		}

	}
}
