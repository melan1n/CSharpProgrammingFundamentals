using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CompareCharArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			//Read arrays
			char[] arr1 = Console.ReadLine().Split(' ').Select(s=>s[0]).ToArray();
			char[] arr2 = Console.ReadLine().Split(' ').Select(s=>s[0]).ToArray();

			//loop through arrays up to the length of the shorter array to compare them 
			bool allCharsEqual = true;
			bool firstIsSmaller = true;

			for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
			{
				if (arr1[i] < arr2[i])
				{
					allCharsEqual = false;
					break;
				}
				else if (arr1[i] > arr2[i])
				{
					allCharsEqual = false;
					firstIsSmaller = false;
					break;
				}
				else
				{
					continue;
				}
			}
			//if all chars up to shorter array length are equal, compare arrays by length
			if (allCharsEqual == true && arr1.Length > arr2.Length)
			{
				firstIsSmaller = false;
			}
			if (firstIsSmaller == true)
			{
				Console.WriteLine(String.Join("", arr1));
				Console.WriteLine(String.Join("", arr2));
			}
			else
			{
				Console.WriteLine(String.Join("", arr2));
				Console.WriteLine(String.Join("", arr1));
			}


		}
	}
}
