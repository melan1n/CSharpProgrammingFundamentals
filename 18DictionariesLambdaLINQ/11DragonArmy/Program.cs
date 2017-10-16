using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11DragonArmy
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dragonTypes = 
				new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();     //<type <name, <stat, value>>>

			for (int i = 0; i < n; i++)
			{
				List<string> input = Console.ReadLine()
					.Split(' ')
					.Select(str => str)
					.ToList();
				string type = input[0];            
				string name = input[1];
				int damage;                  //ASSIGN DEFAULT VALUE if "null": health 250, damage 45, and armor 10
				int health;
				int armor;
				if (!int.TryParse(input[2], out damage))
				{
					damage = 45;
				}
				if (!int.TryParse(input[3], out health))
				{
					health = 250;
				}
				if (!int.TryParse(input[4], out armor))
				{
					armor = 10;
				}
				

				if (!dragonTypes.ContainsKey(type))
				{
					dragonTypes.Add(type, new SortedDictionary<string, Dictionary<string, int>>());
					dragonTypes[type].Add(name, new Dictionary<string, int>());
					dragonTypes[type][name].Add("damage", damage);
					dragonTypes[type][name].Add("health", health);
					dragonTypes[type][name].Add("armor", armor);
				}
				else if (dragonTypes.ContainsKey(type) && !dragonTypes[type].ContainsKey(name))
				{
					dragonTypes[type].Add(name, new Dictionary<string, int>());
					dragonTypes[type][name].Add("damage", damage);
					dragonTypes[type][name].Add("health", health);
					dragonTypes[type][name].Add("armor", armor);
				}
				else if (dragonTypes.ContainsKey(type) && dragonTypes[type].ContainsKey(name))
				{
					dragonTypes[type][name]["damage"] = damage;
					dragonTypes[type][name]["health"] = health;
					dragonTypes[type][name]["armor"] = armor;
				}
			}
			foreach (var dragonType in dragonTypes)
			{
				Console.WriteLine($"{dragonType.Key}::" +
					$"({dragonType.Value.Select(pair => pair.Value["damage"]).Average():F2}/" +
					$"{dragonType.Value.Select(pair => pair.Value["health"]).Average():F2}/" +
					$"{dragonType.Value.Select(pair => pair.Value["armor"]).Average():F2})");
				foreach (var dragonNameStats in dragonTypes[dragonType.Key])
				{
					Console.WriteLine($"-{dragonNameStats.Key} -> damage: {dragonNameStats.Value["damage"]}, health: {dragonNameStats.Value["health"]}, armor: {dragonNameStats.Value["armor"]}");
				}
			}

		}
	}
}
