using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ChooseAdrink
{
	class Program
	{
		static void Main(string[] args)
		{
			var profession = Console.ReadLine();
			var drink = string.Empty;
			switch (profession)
			{
				case "Athlete":  drink = "Water"; break;
				case "Businessman":  drink = "Coffee"; break;
				case "Businesswoman":  drink = "Coffee"; break;
				case "SoftUni Student":  drink = "Beer"; break;
				default: drink = "Tea"; break;
			}
			Console.WriteLine(drink);
		}
	}
}
