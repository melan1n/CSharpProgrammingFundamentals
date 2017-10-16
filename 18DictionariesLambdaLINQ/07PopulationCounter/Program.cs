using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PopulationCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> cityCountry = new Dictionary<string, string>();
			Dictionary<string, long> cityPopulation = new Dictionary<string, long>();
			Dictionary<string, long> countryPopulation = new Dictionary<string, long>();


			string line = Console.ReadLine();
			
			while (line != "report")
			{
				List<string> arguments = line
				.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(str => str)
				.ToList();

				string city = arguments[0];
				string country = arguments[1];
				long population = long.Parse(arguments[2]);

				if (!cityCountry.ContainsKey(city))
				{
					cityCountry.Add(city, country);
					cityPopulation.Add(city, population);
				}
				if (!countryPopulation.ContainsKey(country))
				{
					countryPopulation.Add(country, population);
				}
				else if (countryPopulation.ContainsKey(country))
				{
					long oldpopulation = countryPopulation[country];
					countryPopulation[country] = oldpopulation + population;
				}
				line = Console.ReadLine();
			}
			Dictionary<string, long> sortedCountryPopularion = countryPopulation
				.OrderByDescending(pair => pair.Value)
				.ToDictionary(pair=> pair.Key, pair=>pair.Value);

			foreach (var item in sortedCountryPopularion)
			{
				Console.WriteLine($"{item.Key} (total population: {item.Value})");
				Dictionary<string, string> citiesPerCountry = cityCountry
					.Where(pair => pair.Value == item.Key)
					.ToDictionary(pair => pair.Key, pair => pair.Key);
				Dictionary<string, long> citiesByPopulationPerCountry = new Dictionary<string, long>();
				foreach (var city in citiesPerCountry)
				{
					citiesByPopulationPerCountry.Add(city.Key, cityPopulation[city.Key]);
				}
				Dictionary<string, long> orderedCitiesByPopulationPerCountry = citiesByPopulationPerCountry
					.OrderByDescending(pair => pair.Value)
					.ToDictionary(pair => pair.Key, pair => pair.Value);
				foreach (var cityPop in orderedCitiesByPopulationPerCountry)
				{
					Console.WriteLine($"=>{cityPop.Key}: {cityPop.Value}");
				}
			}
		}
	}
}
