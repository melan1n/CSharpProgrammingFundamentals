using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CenterPoint
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			printCenterPoint(x1, y1, x2, y2);
		}

		static void printCenterPoint(double x1, double y1, double x2, double y2)
		{
			double xResult = 0;
			double yResult = 0;
			double distanceCentreToFirst = (double)Math.Sqrt((double)Math.Pow(x1, 2) + (double)Math.Pow(y1, 2));
			double distanceCentreToSecond = (double)Math.Sqrt((double)Math.Pow(x2, 2) + (double)Math.Pow(y2, 2));
			if (distanceCentreToFirst > distanceCentreToSecond)
			{
				xResult = x2;
				yResult = y2;
			}
			else if (distanceCentreToSecond >= distanceCentreToFirst)
			{
				xResult = x1;
				yResult = y1;
			}
			Console.WriteLine($"({xResult}, {yResult})");
		}
	}
}
