using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AppendLists2
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] tokensArray = Console.ReadLine().Split('|').Select(sequence => sequence).ToArray();
			List<int> resultList = new List<int>();
			for (int i = tokensArray.Length -1; i >= 0; i--)
			{
				int[] charArray = tokensArray[i]
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
					
					resultList.AddRange(charArray);
				
			}
			
			Console.Write(String.Join(" ", resultList));
			
		}
	}
}
