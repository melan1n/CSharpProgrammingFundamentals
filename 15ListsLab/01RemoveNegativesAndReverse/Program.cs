using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RemoveNegativesAndReverse
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
			for (int i = 0; i < list.Count;)
			{
				if (list[i] < 0)
				{
					list.Remove(list[i]);
				}
				else
				{
					i++;
				}
			}
			if (list.Count > 0)
			{
				list.Reverse();
				Console.WriteLine(String.Join(" ", list));
			}
			else
			{
				Console.WriteLine("empty");
			}
		}
	}
}
