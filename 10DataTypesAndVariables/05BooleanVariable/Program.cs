using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BooleanVariable
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			bool myVariable = Convert.ToBoolean(input);

			if (myVariable == true)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
