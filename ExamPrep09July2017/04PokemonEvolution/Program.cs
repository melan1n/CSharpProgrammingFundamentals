using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PokemonEvolution
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dictionary<string, List<int>>> pokemons =
				new Dictionary<string, Dictionary<string, List<int>>>();
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
							foreach (var index in evolution.Value)
							{
								Console.WriteLine($"{evolution.Key} <-> {evolution.Value}");
							}
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
						pokemons.Add(pokemonName, new Dictionary<string, List<int>>() { { evolutionType, new List<int>() { { evolutionIndex } } } });
					}
					else if (pokemons.ContainsKey(pokemonName) && pokemons[pokemonName].ContainsKey(evolutionType))
					{
						pokemons[pokemonName][evolutionType].Add(evolutionIndex);
					}
					else if (pokemons.ContainsKey(pokemonName) && !pokemons[pokemonName].ContainsKey(evolutionType))
					{
						pokemons[pokemonName].Add(evolutionType, new List<int>() { evolutionIndex });
					}
				}
			}
			foreach (var pokemon in pokemons)
			{
				Console.WriteLine($"# {pokemon.Key}");
				foreach (var evolutionIndexList in pokemons[pokemon.Key].Values.Select(x => x).OrderByDescending(keySelector: x => x).ToList())
				{
					//List<int> sortedDescList = evolutionTypePair.Value.Select(x => x).OrderByDescending(keySelector: x => x).ToList();
					//foreach (var index in sortedDescList)
					foreach (var index in evolutionIndexList)
					{
						Console.WriteLine($"{pokemons[pokemon.Key].FirstOrDefault(x => x.Value == evolutionIndexList).Key} <-> {index}");

					}






				}
				
			}
		}
	}
}
