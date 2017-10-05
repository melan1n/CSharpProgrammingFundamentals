using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CubeProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			double side = double.Parse(Console.ReadLine());
			string property = Console.ReadLine();
			if (property == "face")
			{
				Console.WriteLine($"{calculateCubeFaceDiagonal(side):F2}");
			}
			else if (property == "space")
			{
				Console.WriteLine($"{calculateCubeSpaceDiagonal(side):F2}");
			}
			else if (property == "volume")
			{
				Console.WriteLine($"{calculateCubeVolume(side):F2}");
			}
			else if (property == "area")
			{
				Console.WriteLine($"{calculateCubeArea(side):F2}");
			}
		}

		static double calculateCubeArea(double side)
		{
			double area = 6 * Math.Pow(side, 2);
			return area;
		}

		static double calculateCubeVolume(double side)
		{
			double volume = Math.Pow(side, 3);
			return volume;
		}

		static double calculateCubeSpaceDiagonal(double side)
		{
			double spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
			return spaceDiagonal;
		}

		static double calculateCubeFaceDiagonal(double side)
		{
			double faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
			return faceDiagonal;
		}
	}
}