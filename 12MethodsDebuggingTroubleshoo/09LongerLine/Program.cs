using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LongerLine
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double x3 = double.Parse(Console.ReadLine());
			double y3 = double.Parse(Console.ReadLine());
			double x4 = double.Parse(Console.ReadLine());
			double y4 = double.Parse(Console.ReadLine());
			double distanceOne = CalculateDistance(x1, y1, x2, y2);
			double distanceTwo = CalculateDistance(x3, y3, x4, y4);
			if (distanceOne > distanceTwo)
			{
				printCenterPoint(x1, y1, x2, y2);
				printOuterPoint(x1, y1, x2, y2);
			}
			else
			{
				printCenterPoint(x3, y3, x4, y4);
				printOuterPoint(x3, y3, x4, y4);
			}
		}

		static double CalculateDistance(double x1, double y1, double x2, double y2)
		{
			double distance = 0;
			double xSide = Math.Abs(x1) + Math.Abs(x2);
			double ySide = Math.Abs(y1) + Math.Abs(y2);
			distance = Math.Sqrt(Math.Pow(xSide, 2) + Math.Pow(ySide, 2));
			return distance;
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
			Console.Write($"({xResult}, {yResult})");
		}
		static void printOuterPoint(double x1, double y1, double x2, double y2)
		{
			double xResult = 0;
			double yResult = 0;
			double distanceCentreToFirst = (double)Math.Sqrt((double)Math.Pow(x1, 2) + (double)Math.Pow(y1, 2));
			double distanceCentreToSecond = (double)Math.Sqrt((double)Math.Pow(x2, 2) + (double)Math.Pow(y2, 2));
			if (distanceCentreToFirst > distanceCentreToSecond)
			{
				xResult = x1;
				yResult = y1;
			}
			else if (distanceCentreToSecond >= distanceCentreToFirst)
			{
				xResult = x2;
				yResult = y2;
			}
			Console.Write($"({xResult}, {yResult})");
		}
	}
}
