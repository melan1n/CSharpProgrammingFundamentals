using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04Weather
{
	class Program
	{
		class Weather
		{
			public Double Temperature { get; set; }
			public string TypeOfWeather { get; set; }
		}
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";

			Regex regex = new Regex(pattern);

			Dictionary<string, Weather> cityWeather = new Dictionary<string, Weather>();


			while (input != "end")
			{
				Match match = regex.Match(input);

				if (!match.Success)
				{
					input = Console.ReadLine();
					continue;
				}
				else
				{
					if (!cityWeather.ContainsKey(match.Groups[1].Value))
					{
						Weather newWeather = new Weather();
						newWeather.Temperature = double.Parse(match.Groups[2].Value);
						newWeather.TypeOfWeather = match.Groups[3].Value;

						cityWeather.Add(match.Groups[1].Value, newWeather);
					}
					else
					{
						Weather newWeather = new Weather();
						newWeather.Temperature = double.Parse(match.Groups[2].Value);
						newWeather.TypeOfWeather = match.Groups[3].Value;

						cityWeather[match.Groups[1].Value] = newWeather;
					}
				}
				input = Console.ReadLine();
				//match = regex.Match(input);
			}
			foreach (var cityweather in cityWeather.OrderBy(x=>x.Value.Temperature))
			{
				Console.WriteLine($"{cityweather.Key} => {cityweather.Value.Temperature:F2} => {cityweather.Value.TypeOfWeather}");
			}
		}
	}
}
