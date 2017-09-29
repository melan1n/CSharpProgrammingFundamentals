using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13GameOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int magicNumber = int.Parse(Console.ReadLine());
			int comboCount = 0;
			bool magicFound = false;

			for (int i = m; i >= n; i--)
			{
				for (int j = m; j >= n; j--)
				{
					int tempNum = i + j;
					comboCount++;

					if (tempNum == magicNumber)
					{
						magicFound = true;
						Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
						break;
					}
				}
				if (magicFound == true)
				{
					break;
				}
			}
			if (magicFound == false)
			{
				Console.WriteLine($"{comboCount} combinations - neither equals {magicNumber}");
			}

		}
	}
}
