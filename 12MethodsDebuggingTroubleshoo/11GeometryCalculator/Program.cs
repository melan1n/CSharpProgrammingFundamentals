using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11GeometryCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string figure = Console.ReadLine();
			if (figure == "triangle")
			{
				double side = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				Console.WriteLine($"{CalculateTriangleArea(side, height):f2}");
			}
			else if (figure == "rectangle")
			{
				double width = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				Console.WriteLine($"{CalculateRectangleArea(width, height):f2}");
			}
			else if (figure == "square")
			{
				double side = double.Parse(Console.ReadLine());
				Console.WriteLine($"{CalculateSquareArea(side):f2}");
			}
			else if (figure == "circle")
			{
				double radius = double.Parse(Console.ReadLine());
				Console.WriteLine($"{CalculateCircleArea(radius):f2}");
			}
		}

		static double CalculateCircleArea(double radius)
		{
			double area = Math.PI * Math.Pow(radius, 2);
			return area;
		}

		static double CalculateSquareArea(double side)
		{
			double area = Math.Pow(side, 2);
			return area;
		}

		static double CalculateRectangleArea(double width, double height)
		{
			double area = height * width;
			return area;
		}

		static double CalculateTriangleArea(double side, double height)
		{
			double area = height * side / 2;
			return area;
		}
	}
}
