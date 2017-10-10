using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AppendLists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> collection = Console.ReadLine().Split('|').Select(sequence => sequence).ToList();
			List<char[]> resultList = new List<char[]>();
			//List<char> resultList = new List<char>();
			foreach (var list in collection)
			{
				char[] numbersBlock = list
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(ch => Convert.ToChar(ch))
					.ToArray();
				resultList.Add(numbersBlock);
			}
			resultList.Reverse();
			for (int i = 0; i < resultList.Count; i++)
			{
				Console.Write(String.Join(" ", resultList[i]) + $" ");
			}
		}
	}
}
