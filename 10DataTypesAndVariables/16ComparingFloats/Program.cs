using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ComparingFloats
{
	class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double esp = 0.000001;

			bool areEqual = false;

			if (Math.Abs(a-b) <= esp)
			{
				areEqual = true;
			}
			Console.WriteLine(areEqual);
		}
	}
}
