using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BeverageLabels
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int volume = int.Parse(Console.ReadLine());
			int energy = int.Parse(Console.ReadLine());
			int sugar = int.Parse(Console.ReadLine());

			Console.WriteLine($"{volume}ml {name}:");
			Console.WriteLine($"{(float)(volume)/100*energy}kcal, {(float)volume/100*sugar}g sugars");

		}
	}
}
