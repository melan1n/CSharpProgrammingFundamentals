using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01HornetWings
{
	class Program
	{
		static void Main(string[] args)
		{
			int flaps = int.Parse(Console.ReadLine());
			double distancePer1000Flaps = double.Parse(Console.ReadLine());
			int endurance = int.Parse(Console.ReadLine());
			int flapsPerSecond = 100;
			int time = flaps / flapsPerSecond;
			int rest = 5;

			decimal metersTraveled = ((decimal)flaps / (decimal)1000 ) * (decimal)distancePer1000Flaps;
			decimal secondsPassed = (flaps / endurance) * rest + (flaps/flapsPerSecond);


			Console.WriteLine($"{metersTraveled:F2} m.");
			Console.WriteLine($"{secondsPassed} s.");

		}
	}
}
