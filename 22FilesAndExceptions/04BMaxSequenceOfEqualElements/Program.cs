using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BMaxSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input4b.txt", "7 7 4 4 5 5 3 3");
			//read int[n] from console
			int[] arr = File.ReadAllText("input4B.txt").Split(' ').Select(int.Parse).ToArray();
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
			File.WriteAllText("output4B.txt", result);

		}
	}
}
