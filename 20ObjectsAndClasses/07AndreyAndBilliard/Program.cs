using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _07AndreyAndBilliard
{
	class Customer
	{
		public string Name { get; set; }
		public Dictionary<string, int> Buys { get; set; }
		public decimal Bill { get; set; }

	}
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, decimal> shop =
				new Dictionary<string, decimal>();             //Dictionary shop<product, price>
			List<Customer> customers =
				new List<Customer>();							//Dictionary customers<Customer objects>
			for (int i = 0; i < n; i++)
			{
				string[] productLine =
					Console.ReadLine()
					.Split('-')
					.ToArray();
				string product = productLine[0];
				decimal price = decimal.Parse(productLine[1]);
				if (!shop.ContainsKey(product))
				{
					shop.Add(product, price);
				}
				else
				{
					shop[product] = price;
				}
			}
			while (true)
			{
				string input = Console.ReadLine();
				string[] inputLine =
						input
						.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
						.ToArray();
				string newName = inputLine[0];
					
				
				if (input == "end of clients")
				{
					break;
				}
				else if (!shop.ContainsKey(inputLine[1]))
				{
					continue;
				}
				else
				{
					string newProduct = inputLine[1];
					int quantity = int.Parse(inputLine[2]);

					int existingCustomer = customers.Where(c => c.Name == newName).ToList().Count; //Check (by Customer.Name) if an object is present in the customers list. If 0 -> no, else -> yes
					if (existingCustomer == 0)
					{
						Customer customer = new Customer();
						customer.Name = newName;
						Dictionary<string, int> buys = new Dictionary<string, int>();
						buys.Add(newProduct, quantity);
						customer.Buys = buys;
						customer.Bill =
							quantity * shop[newProduct];
						
						customers.Add(customer);
					}
					else if (existingCustomer != 0
						&& customers.Where(c => c.Name == newName).First().Buys.ContainsKey(newProduct)) 
					{
						customers.Where(c => c.Name == newName).First().Buys[newProduct] += quantity;
						decimal oldBill = customers.Where(c => c.Name == newName).First().Bill;
						customers.Where(c => c.Name == newName).First().Bill =
							oldBill + quantity * shop[newProduct];
					}
					else if (existingCustomer != 0
						&& !customers.Where(c => c.Name == newName).First().Buys.ContainsKey(newProduct))
					{
						customers.Where(c => c.Name == newName).First().Buys.Add(newProduct, quantity);
						decimal oldBill = customers.Where(c => c.Name == newName).First().Bill;
						customers.Where(c => c.Name == newName).First().Bill =
							oldBill + quantity * shop[newProduct];
					}
				}
			}
			foreach (var customer in customers.OrderBy(c => c.Name))
			{
				Console.WriteLine($"{customer.Name}");
				foreach (var buys in customer.Buys)
				{
					Console.WriteLine($"-- {buys.Key} - {buys.Value}");
				}
				Console.WriteLine($"Bill: {customer.Bill:F2}");
			}
			Console.WriteLine($"Total bill: {customers.Sum(c => c.Bill):F2}");

		}
		
	

	}
	}

