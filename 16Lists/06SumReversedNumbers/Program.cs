using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumReversedNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> numbers = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x)
				.ToList();
			

			List<int> numbersInt = new List<int>();

			foreach (string number in numbers)
			{
				char[] numberCharArray = number.ToCharArray();
				Array.Reverse(numberCharArray);
				string numberString = new string(numberCharArray);
				int numberInt = int.Parse(numberString);
				numbersInt.Add(numberInt);
			}

			Console.WriteLine(numbersInt.Sum());

		}
	}
}
