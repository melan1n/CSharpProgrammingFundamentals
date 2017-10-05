using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MaxMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			int secondNum = int.Parse(Console.ReadLine());
			int thirdNum = int.Parse(Console.ReadLine());

			int biggerOfFirstPair = GetMax(firstNum, secondNum);
			Console.WriteLine(GetMax(biggerOfFirstPair, thirdNum));
		}
		static int GetMax(int a, int b)
		{
			if (a > b)
			{
				return a; 
			}
			else
			{
				return b;
			}
		}

	}
}
	

