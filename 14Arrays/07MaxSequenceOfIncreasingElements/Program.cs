using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxSequenceOfIncreasingElements
{
	class Program
	{
		static void Main(string[] args)
		{
			//read int[n] from console
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int countCurrent = 1;
			int countOfLongestIncreasingSequence = 1;
			int lastElementIndex = int.MinValue;
			//Loop through array, have current counter and compare to main counter
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > arr[i - 1])
				{
					countCurrent++;
				}
				else
				{
					countCurrent = 1;
				}
				if (countCurrent > countOfLongestIncreasingSequence)
				{
					countOfLongestIncreasingSequence = countCurrent;
					lastElementIndex = i;
				}
			}
			for (int i = lastElementIndex - countOfLongestIncreasingSequence + 1; i <= lastElementIndex; i++)
			{
				Console.Write($"{arr[i]} ");
			}

		}
	}
}
