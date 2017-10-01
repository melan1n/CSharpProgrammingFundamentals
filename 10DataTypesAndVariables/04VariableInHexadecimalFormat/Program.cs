using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableInHexadecimalFormat
{
	class Program
	{
		static void Main(string[] args)
		{
			string hexadecimal = Console.ReadLine();
			int decimalNumber = Convert.ToInt32(hexadecimal, 16);

			Console.WriteLine(decimalNumber);
		}
	}
}
