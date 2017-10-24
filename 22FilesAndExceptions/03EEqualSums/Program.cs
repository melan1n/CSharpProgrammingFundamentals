using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EEqualSums
{
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input3E.txt", "10 5 5 99 3 4 2 5 1 1 4");
			int[] arr = File.ReadAllText("input3E.txt").Split(' ').Select(int.Parse).ToArray();
			int indexResult = -1;

			for (int i = 0; i < arr.Length; i++)
			{
				int[] arrLeft = (int[])arr.Take(i).ToArray();
				int[] arrRight = (int[])arr.Skip(i + 1).ToArray();
				if (arrLeft.Sum() == arrRight.Sum())
				{
					indexResult = i;
					break;
				}
			}
			if (indexResult == -1)
			{
				File.WriteAllText("output3E.txt", "no");
			}
			else
			{
				File.WriteAllText("output3E.txt", indexResult.ToString());
			}
		}
	}
}
