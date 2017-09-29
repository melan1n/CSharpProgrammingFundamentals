using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			var month = Console.ReadLine();
			int nightsCount = int.Parse(Console.ReadLine());
			int priceStudioPerNight = 0;
			int priceDoublePerNight = 0;
			int priceSuitePerNight = 0;
			double discountPerStudio = 0;
			double discountPerDouble = 0;
			double discountPerSuite = 0;

			switch (month)
			{
				case "May":
					priceStudioPerNight = 50;
					priceDoublePerNight = 65;
					priceSuitePerNight = 75;
					break;
				case "October":
					priceStudioPerNight = 50;
					priceDoublePerNight = 65;
					priceSuitePerNight = 75;
					break;
				case "June":
					priceStudioPerNight = 60;
					priceDoublePerNight = 72;
					priceSuitePerNight = 82;
					break;
				case "September":
					priceStudioPerNight = 60;
					priceDoublePerNight = 72;
					priceSuitePerNight = 82;
					break;
				case "July":
					priceStudioPerNight = 68;
					priceDoublePerNight = 77;
					priceSuitePerNight = 89;
					break;
				case "August":
					priceStudioPerNight = 68;
					priceDoublePerNight = 77;
					priceSuitePerNight = 89;
					break;
				case "December":
					priceStudioPerNight = 68;
					priceDoublePerNight = 77;
					priceSuitePerNight = 89;
					break;
			}
			if (nightsCount > 7 && (month=="May" || month == "Ocotber"))
			{
				discountPerStudio = 0.05;
			}
			else if (nightsCount > 14 && (month == "June" || month == "September"))
			{
				discountPerDouble = 0.10;
			}
			else if (nightsCount > 14 && (month == "July" || month == "August" || month == "December"))
			{
				discountPerSuite = 0.15;
			}
			else if (nightsCount > 7 && (month == "September" || month == "October"))
			{
				discountPerStudio = (double)1/nightsCount;
			}
			double priceStudio = (nightsCount * priceStudioPerNight) * (1 - discountPerStudio);
			double priceDouble = (nightsCount * priceDoublePerNight) * (1 - discountPerDouble);
			double priceSuite = (nightsCount * priceSuitePerNight) * (1 - discountPerSuite);

			Console.WriteLine($"Studio: {priceStudio:F2} lv.");
			Console.WriteLine($"Double: {priceDouble:F2} lv.");
			Console.WriteLine($"Suite: {priceSuite:F2} lv.");
		}
	}
}
