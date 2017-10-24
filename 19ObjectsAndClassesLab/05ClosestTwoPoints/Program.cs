using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ClosestTwoPoints
{
	class Program
	{
		class Point
		{
			public int x { get; set; }
			public int y { get; set; }
		}
		
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Point[] points = new Point[n];
			for (int i = 0; i < n; i++)
			{
				points[i] = ReadPoint();
			}
			Point[] closestPoints = FindClosestPoints(points);
			Console.WriteLine($"{CalculateDistance(closestPoints[0], closestPoints[1]):F3}");
			Console.WriteLine($"({closestPoints[0].x} {closestPoints[0].y})");
			Console.WriteLine($"({closestPoints[1].x} {closestPoints[1].y})");

		}

		static Point[] FindClosestPoints(Point[] points)
		{
			Point[] result = new Point[] { points[0], points[1 ]};
			double minDist = double.MaxValue;
			for (int i = 0; i < points.Length-1; i++)
			{
				for (int j= i+1; j < points.Length; j++)
				{
					if (i != j && CalculateDistance(points[i], points[j]) < minDist)
					{
						result[0] = points[i];
						result[1] = points[j];
						minDist = CalculateDistance(points[i], points[j]);

					}
				}
			}
			return result;
		}

		static double CalculateDistance(Point point1, Point point2)
		{
			double distance = 0;
			int deltaX = Math.Abs(point1.x - point2.x);
			int deltaY = Math.Abs(point1.y - point2.y);

			distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
			return distance;
		}

		static Point ReadPoint()
		{
			Point result = new Point();
			int[] coordinates = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			result.x = coordinates[0];
			result.y = coordinates[1];

			return result;
		}
	}
}
