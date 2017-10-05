using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PrimesInGivenRange
{
	class Program
	{
		static void Main(string[] args)
		{
			int startNum = int.Parse(Console.ReadLine());
			int endNum = int.Parse(Console.ReadLine());
			printList(FindPrimesInRange(startNum, endNum));
		}
		static List<int> FindPrimesInRange(int startNum, int endNum)
		{
			List<int> result = new List<int>();
			for (int i = startNum; i <= endNum; i++)
			{
				if (IsPrime(i) == true)
				{
					result.Add(i);
				}
			}
			return result;
		}
		static void printList(List<int> list)
		{
			for (int i = 0; i <= list.Count-2; i++)
			{
				Console.Write($"{list[i]}, ");
			}
			Console.Write(list[list.Count-1]);

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
