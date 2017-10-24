using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IntersectionOfCircles
{
	class Program
	{
		class Circle
		{
			public Point Center { get; set; }
			public int Radius { get; set; }

			internal bool IsInside(Circle circle)
			{
				bool result = false;
				int deltaX = Math.Abs(circle.Center.X - this.Center.X);
				int deltaY = Math.Abs(circle.Center.Y - this.Center.Y);

				double distanceBetweenCenters =	Math.Sqrt(Math.Pow((double)deltaX, 2) +
					Math.Pow((double)deltaY, 2));
				if (distanceBetweenCenters <= this.Radius + circle.Radius)
				{
					result = true;
				}
				return result;
			}
		}
		class Point
		{
			public int X { get; set; }
			public int Y { get; set; }
		}

		static void Main(string[] args)
		{
			Circle c1 = ReadCircle();
			Circle c2 = ReadCircle();

			Console.WriteLine(c1.IsInside(c2)? "Yes" : "No"); 

		}

		static Circle ReadCircle()
		{
			Circle result = new Circle();
			Point resultCenter = new Point();
			int[] props = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			result.Center = resultCenter;
			resultCenter.X = props[0];
			resultCenter.Y = props[1];
			result.Radius = props[2];
			return result;

		}
	}
}
