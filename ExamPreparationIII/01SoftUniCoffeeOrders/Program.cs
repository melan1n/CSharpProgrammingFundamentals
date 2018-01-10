using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01SoftUniCoffeeOrders
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<decimal> prices = new List<decimal>();
			for (int i = 0; i < n; i++)
			{
				decimal price = decimal.Parse(Console.ReadLine());
				DateTime date = DateTime.ParseExact(
					Console.ReadLine()
					, "d/M/yyyy"
					, CultureInfo.InvariantCulture);

				int daysInMonth = DateTime.DaysInMonth(
				date.Year,
				date.Month);
				int capsules = int.Parse(Console.ReadLine());
				decimal priceInMonth = (decimal)daysInMonth * (decimal)capsules * price;
				Console.WriteLine($"The price for the coffee is: ${priceInMonth:F2}");
				prices.Add(priceInMonth);
			}
			Console.WriteLine($"Total: ${prices.Sum():F2}");
		}
	}
}
