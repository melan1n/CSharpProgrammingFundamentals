using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal n = int.Parse(Console.ReadLine());
			int key = int.Parse(Console.ReadLine());

			List<string> sites = new List<string>();
			decimal totalLoss = 0;
			for (int i = 0; i < n; i++)
			{
				List<string> inputLine = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(x => x)
					.ToList();
				string siteName = inputLine[0];
				decimal siteVisits = decimal.Parse(inputLine[1]);
				decimal siteCommercialPricePerVisit = decimal.Parse(inputLine[2]);

				sites.Add(siteName);
				totalLoss += (decimal)siteVisits * (decimal)siteCommercialPricePerVisit;
			}


			for (int i = 0; i < sites.Count; i++)
			{
				Console.WriteLine(sites[i]);
			}
			Console.WriteLine($"Total Loss: {totalLoss:F20}");

			BigInteger securityToken = 1;
			for (int i = 0; i < sites.Count; i++)
			{
				securityToken = securityToken * (BigInteger)key;
			}
			Console.WriteLine($"Security Token: {securityToken}");

		}
	}
}
