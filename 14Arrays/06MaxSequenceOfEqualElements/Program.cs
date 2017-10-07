using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaxSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			//read int[n] from console
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int countCurrent = 1;
			int countOfLongestEqualSequence = 1;
			int arrayElement = int.MinValue;
			//Loop through array, have current counter and compare to main counter
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] == arr[i-1])
				{
					countCurrent++;
				}
				else
				{
					countCurrent = 1;
				}
				if (countCurrent > countOfLongestEqualSequence)
				{
					countOfLongestEqualSequence = countCurrent;
					arrayElement = arr[i];
				}
			}
			for (int i = 0; i < countOfLongestEqualSequence; i++)
			{
				Console.Write($"{arrayElement} ");
			}

		}
	}
}
