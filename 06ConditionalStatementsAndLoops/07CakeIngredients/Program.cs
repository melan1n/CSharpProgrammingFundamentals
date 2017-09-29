using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CakeIngredients
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int count = 0;
			while (true)
			{
				string ingredient = Console.ReadLine();
				if (ingredient != "Bake!")
				{
					Console.WriteLine($"Adding ingredient {ingredient}.");
					count++;
				}
				else
				{
					Console.WriteLine($"Preparing cake with {count} ingredients.");
					break;
				}
			}
			
		}
	}
}
