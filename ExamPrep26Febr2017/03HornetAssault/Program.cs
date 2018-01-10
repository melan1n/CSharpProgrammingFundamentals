using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HornetAssault
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> bees = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			List<long> hornets = Console.ReadLine()
				.Split(' ')
				.Select(long.Parse)
				.ToList();
			for (int i = 0; i < bees.Count; i++)
			{
				long hornetsPower = (long)hornets.Sum();

				if (hornetsPower < bees[i])
				{
					bees[i] -= (int)hornetsPower;
					hornets.Remove(hornets[0]);
				}
				else if (hornetsPower > bees[i])
				{
					bees[i] = 0;
				}
				else if (hornetsPower == bees[i])
				{
					bees[i] = 0;
					hornets.Remove(hornets[0]);

				}
				if (hornets.Count() == 0 || i == bees.Count-1)
				{
					break;
				}
			}

			if (bees.Sum() > 0)
			{
				Console.WriteLine($"{string.Join(" ", bees.Where(b=>b != 0))}");
			}
			else
			{
				Console.WriteLine($"{string.Join(" ", hornets)}");
			}
		}
	}
}
