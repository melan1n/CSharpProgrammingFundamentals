using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FoldAndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			int k = nums.Count / 4;
			List<int> row1 = new List<int> (nums.Take(k).Reverse().ToList().Concat(nums.Skip(3*k).Take(k).Reverse().ToList()));
			List<int> row2 = new List<int>(nums.Skip(k).Take(2 * k).ToList());
			for (int i = 0; i < row1.Count; i++)
			{
				Console.Write($"{row1[i] + row2[i]} ");
			}

		}
	}
}
