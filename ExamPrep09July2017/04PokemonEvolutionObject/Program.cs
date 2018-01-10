using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PokemonEvolutionObject
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<Evolution>> pokemons =
				new Dictionary<string, List<Evolution>>();
			while (true)
			{
				string commandLine = Console.ReadLine();

				if (commandLine == "wubbalubbadubdub")
				{
					break;
				}

				List<string> commands =
					commandLine
					.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(x => x)
					.ToList();
				if (commands.Count == 1)
				{
					string pokemonToPrint = commands[0];
					if (pokemons.ContainsKey(pokemonToPrint))
					{
						Console.WriteLine($"# {pokemonToPrint}");
						foreach (var evolution in pokemons[pokemonToPrint])
						{
							
								Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
							
						}
					}
				}
				else
				{
					string pokemonName = commands[0];
					string evolutionType = commands[1];
					int evolutionIndex = int.Parse(commands[2]);

					if (!pokemons.ContainsKey(pokemonName))
					{
						pokemons.Add(pokemonName, new List<Evolution>());
						Evolution evolution = new Evolution();
						evolution.EvolutionType = evolutionType;
						evolution.EvolutionIndex = evolutionIndex;
						pokemons[pokemonName].Add(evolution);
					}
					else 
					{
						Evolution evolution = new Evolution();
						evolution.EvolutionType = evolutionType;
						evolution.EvolutionIndex = evolutionIndex;
						pokemons[pokemonName].Add(evolution);
					}
				}
			}
			foreach (var pokemon in pokemons)
			{
				Console.WriteLine($"# {pokemon.Key}");
				foreach (var evolution in pokemons[pokemon.Key].Select(e=>e).OrderByDescending(e => e.EvolutionIndex).ToList())
				{
					Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
				}

			}
		}
	}

	internal class Evolution
	{
		public string EvolutionType { get; set; }
		public int EvolutionIndex { get; set; }
	}
}
