using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MilesToKilometers
{
	class Program
	{
		static void Main(string[] args)
		{
			float miles = float.Parse(Console.ReadLine());
			Console.WriteLine($"{miles*1.60934:F2}");
		}
	}
}
