using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DistanceBetweenPoints
{
	class Program
	{
		class Point
		{
			public int X { get; set; }
			public int Y { get; set; }
		}
		static void Main(string[] args)
		{
			Point a = ReadPoint();
			Point b = ReadPoint();

			double distance = CalculateDistance(a, b);
			Console.WriteLine($"{distance:F3}");
		}
		static Point ReadPoint()
		{
			Point result = new Point();
			int[] coordinates = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToArray();
			result.X = coordinates[0];
			result.Y = coordinates[1];

			return result;
		}
				
		static double CalculateDistance(Point a, Point b)
		{
			double result = 0;
			int deltaX = Math.Abs(a.X - b.X);
			int deltaY = Math.Abs(a.Y - b.Y);

			result = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
			return result;
		}
	}
}
