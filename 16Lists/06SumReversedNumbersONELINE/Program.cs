using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumReversedNumbersONELINE
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbersInt = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(str => int.Parse(new string(str.ToCharArray().Reverse().ToArray())))
				.ToList();
			Console.WriteLine(numbersInt.Sum());
		}
	}
}
