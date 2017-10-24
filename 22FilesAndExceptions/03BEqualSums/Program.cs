using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BEqualSums
{
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input3B.txt", "1 2");
			int[] arr = File.ReadAllText("input3B.txt").Split(' ').Select(int.Parse).ToArray();
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
				File.WriteAllText("output3B.txt", "no");
			}
			else
			{
				File.WriteAllText("output3B.txt", indexResult.ToString());
			}
		}
	}
}
