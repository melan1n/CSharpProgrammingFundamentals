using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SweetDessert
{
	class Program
	{
		static void Main(string[] args)
		{
			//set of 6 she needs 2 bananas, 4 eggs and 0.2 kilos berries.
			decimal cash = decimal.Parse(Console.ReadLine());
			decimal guests = decimal.Parse(Console.ReadLine());
			decimal priceBanana= decimal.Parse(Console.ReadLine());
			decimal priceEggs = decimal.Parse(Console.ReadLine());
			decimal priceBerries = decimal.Parse(Console.ReadLine());

			decimal costPerPortion =
				2 * priceBanana +
				4 * priceEggs +
				(decimal) 0.2 * priceBerries;
			decimal portions = Math.Ceiling(guests / 6);
			decimal need = portions * costPerPortion;

			if (cash - need >= 0)
			{
				Console.WriteLine($"Ivancho has enough money - it would cost {need:F2}lv."); 

			}
			else
			{
				Console.WriteLine($"Ivancho will have to withdraw money - he will need {(need - cash):F2}lv more.");
			}				

		}
	}
}
