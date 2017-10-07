using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LargestCommonEnd
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr1 = Console.ReadLine().Split(' ');
			string[] arr2 = Console.ReadLine().Split(' ');
			int countLeft = 0;
			for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
			{
				if (arr1[i] == arr2[i])
				{
					countLeft++;
				}
				else
				{
					break;
				}
			}
			int countRight = 0;
			for (int i = 0 ; i <= Math.Min(arr1.Length - 1, arr2.Length - 1); i++)
			{
				if (arr1[arr1.Length - i - 1] == arr2[arr2.Length - i - 1])
				{
					countRight++;
				}
				else
				{
					break;
				}
			}
			Console.WriteLine(Math.Max(countLeft, countRight));
			
		}
	}
}
