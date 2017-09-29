using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15NeighbourWars
{
	class Program
	{
		static void Main(string[] args)
		{
			int damagePesho = int.Parse(Console.ReadLine());
			int damageGosho = int.Parse(Console.ReadLine());
			int healthPesho = 100;
			int healthGosho = 100;
			int turn = 1;

			while (true)
			{
					
				if (turn % 2 == 1)
				{
					healthGosho -= damagePesho;
					if (healthGosho > 0)
					{
						Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
					}
				}
				else if (turn % 2 == 0)
				{
					healthPesho -= damageGosho;
					if (healthPesho > 0)
					{
						Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");

					}
				}
				if (turn % 3 == 0 && healthPesho > 0 && healthGosho > 0)
				{
					healthPesho += 10;
					healthGosho += 10;
				}
				if (healthPesho <= 0 || healthGosho <= 0)
				{
					if (healthPesho > 0)
					{
						Console.WriteLine($"Pesho won in {turn}th round.");
					}
					else
					{
						Console.WriteLine($"Gosho won in {turn}th round.");
					}
					break;
				}
				turn++;
			}
		}
	}
}
