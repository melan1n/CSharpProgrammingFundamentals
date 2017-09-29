using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RestaurantDiscount
{
	class Program
	{
		static void Main(string[] args)
		{
			int groupSize = int.Parse(Console.ReadLine());
			string package = Console.ReadLine();
			string hallName = string.Empty;
			int hallPrice = 0;
			int packagePrice = 0;
			double discount = 0;
			int totalPrice = 0;

			if (groupSize <= 50)
			{
				hallName = "Small Hall";
				hallPrice = 2500;
			}
			if (groupSize > 50 && groupSize <=100)
			{
				hallName = "Terrace";
				hallPrice = 5000;
			}
			if (groupSize > 100 && groupSize <= 120)
			{
				hallName = "Great Hall";
				hallPrice = 7500;
			}
			switch (package)
			{
				case "Normal": discount = 0.05; packagePrice = 500; break;
				case "Gold": discount = 0.10; packagePrice = 750; break;
				case "Platinum": discount = 0.15; packagePrice = 1000; break;
			}

			double price = (hallPrice + packagePrice)*(1 - discount);
			if (groupSize <= 120)
			{
				Console.WriteLine($"We can offer you the {hallName}");
				Console.WriteLine($"The price per person is {price/groupSize:F2}$");
			}
			else
			{
				Console.WriteLine($"We do not have an appropriate hall.");
			}
			

		}
	}
}
