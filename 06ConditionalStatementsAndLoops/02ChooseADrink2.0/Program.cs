using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChooseADrink2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			var profession = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());

			var drink = string.Empty;
			double price = 0;
			switch (profession)
			{
				case "Athlete": drink = "Water"; price = 0.70; break;
				case "Businessman": drink = "Coffee"; price = 1; break;
				case "Businesswoman": drink = "Coffee"; price = 1; break;
				case "SoftUni Student": drink = "Beer"; price = 1.70; break;
				default: drink = "Tea"; price = 1.20; break;
			}
			Console.WriteLine($"The {profession} has to pay {quantity*price:F2}.");
		}
	}
}
