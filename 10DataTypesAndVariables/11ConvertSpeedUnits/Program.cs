using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
	class Program
	{
		static void Main(string[] args)
		{
			int meters = int.Parse(Console.ReadLine());
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int seconds = int.Parse(Console.ReadLine());

			float metersPerSecond = (float)meters / (hours * 3600 + minutes * 60 + seconds);
			float kilometersPerHour = ((float)meters / 1000) / ((hours + (float)(minutes)/60 + (float)(seconds)/3600));
			float milesPerHour = ((float)meters/1609) / ((hours + (float)(minutes) / 60 + (float)(seconds) / 3600));

			Console.WriteLine($"{metersPerSecond}");
			Console.WriteLine($"{kilometersPerHour}");
			Console.WriteLine($"{milesPerHour}");
		}
	}
}
