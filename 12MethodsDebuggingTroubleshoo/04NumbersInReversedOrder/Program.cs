using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NumbersInReversedOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			printInReversedOrder(number);
		}
		static void printInReversedOrder(string number)
		{
			for (int i = number.Length - 1; i >= 0; i--)
			{
				Console.Write(number[i]);
			}

		}
	}
}
