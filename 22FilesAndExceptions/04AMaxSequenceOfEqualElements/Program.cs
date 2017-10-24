using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04AMaxSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input4A.txt", "3 4 4 5 5 5 2 2");
			//read int[n] from console
			int[] arr = File.ReadAllText("input4A.txt").Split(' ').Select(int.Parse).ToArray();
			int countCurrent = 1;
			int countOfLongestEqualSequence = 1;
			int arrayElement = int.MinValue;
			//Loop through array, have current counter and compare to main counter
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] == arr[i - 1])
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
			string result = String.Empty;
			for (int i = 0; i < countOfLongestEqualSequence; i++)
			{
				result = result + arrayElement.ToString() + " ";
			}
			File.WriteAllText("output4A.txt", result);

		}
	}
}
