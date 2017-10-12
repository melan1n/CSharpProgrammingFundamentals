using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LongestSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			int longestSequence = 1;
			int longestSequnceStart = 0;
			int currentLongestSequence = 1;

			for (int i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] == numbers[i-1])
				{
					currentLongestSequence++;
				}
				else
				{
					currentLongestSequence = 1;
				}
				if (currentLongestSequence > longestSequence)
				{
					longestSequence = currentLongestSequence;
					longestSequnceStart = i - longestSequence + 1;
				}
			}
			for (int i = longestSequnceStart; i < longestSequnceStart + longestSequence; i++)
			{
				Console.Write($"{numbers[i]} ");
			}
			
		}
	}
}
