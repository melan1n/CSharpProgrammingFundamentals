using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ExchangeVariableValues
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			int b;
			a = 5;
			b = 10;
			Console.WriteLine("Before:");
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");

			int temp = b;
			b = a;
			a = temp;
			Console.WriteLine("After:");
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");


		}
	}
}
