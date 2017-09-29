using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CharacterStars
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int currentHealth = int.Parse(Console.ReadLine());
			int maxHealth = int.Parse(Console.ReadLine());
			int currentEnergy = int.Parse(Console.ReadLine());
			int maxEnergy = int.Parse(Console.ReadLine());

			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Health: {new string('|', currentHealth + 1)}{new string('.', maxHealth - currentHealth)}|");
			Console.WriteLine($"Energy: {new string('|', currentEnergy + 1)}{new string('.', maxEnergy - currentEnergy)}|");


		}
	}
}
