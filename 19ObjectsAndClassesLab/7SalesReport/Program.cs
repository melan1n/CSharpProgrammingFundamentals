using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7SalesReport
{
	class Program
	{
		class Sale
		{
			public string Town { get; set; }
			public string Product { get; set; }
			public double Price { get; set; }
			public double Quantity { get; set; }
		}
		static void Main(string[] args)
		{
			//Read sales n + (town, product, price, quan)
			int n = int.Parse(Console.ReadLine());
			SortedDictionary<string, double> totalSales = new SortedDictionary<string, double>();
			for (int i = 0; i < n; i++)
			{
				Sale newSale = ReadSale();
				if (!totalSales.ContainsKey(newSale.Town))
				{
					totalSales.Add(newSale.Town, newSale.Price * newSale.Quantity);
				}
				else
				{
					totalSales[newSale.Town] += newSale.Price * newSale.Quantity;
				}
			}
			//calculate and print total by town -> 96.80
			foreach (var item in totalSales)
			{
				Console.WriteLine($"{item.Key} -> {item.Value:F2}");
			}
		}

		static Sale ReadSale()
		{
			Sale result = new Sale();
			string[] saleProps = Console.ReadLine()
				.Split(' ')
				.Select(s => s)
				.ToArray();
			result.Town = saleProps[0];
			result.Product = saleProps[1];
			result.Price = double.Parse(saleProps[2]);
			result.Quantity = double.Parse(saleProps[3]);
			return result;
		}
	}
}
