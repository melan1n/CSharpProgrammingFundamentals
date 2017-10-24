using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01DayOfWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			string day = Console.ReadLine();
			DateTime date = DateTime.ParseExact(day, "d-M-yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine($"{date.DayOfWeek}");
		}
	}
}
