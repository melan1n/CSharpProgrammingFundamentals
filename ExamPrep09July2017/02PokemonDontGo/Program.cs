using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02PokemonDontGo
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> distances =
				Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			List<int> result =
				new List<int>();

			while (distances.Count != 0)
			{
				int index = int.Parse(Console.ReadLine());
				if (index < 0)
				{
					ApplyNumber(distances, 0);
					result.Add(distances[0]);
					distances[0] = distances[distances.Count-1];
				}
				else if (index >= 0 && index <distances.Count)
				{
					ApplyNumber(distances, index);
					result.Add(distances[index]);
					distances.RemoveAt(index);
				}
				else
				{
					ApplyNumber(distances, distances.Count - 1);
					result.Add(distances[distances.Count - 1]);
					distances[distances.Count - 1] = distances[0];
					
				}
				
			}
			Console.WriteLine(result.Sum());
		}

		static void ApplyNumber(List<int> distances, int index)
		{
			int number = distances[index];
			for (int i = 0; i < distances.Count; i++)
			{
				if (distances[i] <= number && i!= index)
				{
					distances[i] = distances[i] + number;
				}
				else if (distances[i] > number && i != index)
				{
					distances[i] = distances[i] - number;

				}
			}
		}
	}
}
