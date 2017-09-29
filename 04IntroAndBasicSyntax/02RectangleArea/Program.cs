using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RectangleArea
{
	class Program
	{
		static void Main(string[] args)
		{
			float height = float.Parse(Console.ReadLine());
			float width = float.Parse(Console.ReadLine());
			float area = height * width;
			Console.WriteLine($"{area:F2}");
		}
	}
}
