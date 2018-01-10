using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04HornetArmada
{
	class Program
	{
		
		static void Main(string[] args)
		{
			var n = long.Parse(Console.ReadLine());
			Dictionary<string, Dictionary<string, long>> legions=
				new Dictionary<string, Dictionary<string, long>>();
			Dictionary<string, long> legionLastActivity =
				new Dictionary<string, long>();
			for (int i = 0; i < n; i++)
			{
				List<string> tokens = Console.ReadLine()
					.Split(new char[] { '=', '-', '>', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(x => x.Trim())
					.ToList();
				long lastActivity = long.Parse(tokens[0]);
				string legionName = tokens[1];
				string soldierType = tokens[2];
				long soldierCount = long.Parse(tokens[3]);

				if (!legions.ContainsKey(legionName))
				{
					legions.Add(legionName, new Dictionary<string, long>() { { soldierType, soldierCount } });
					legionLastActivity.Add(legionName, lastActivity);
				}
				else if (legions.ContainsKey(legionName) && !legions[legionName].ContainsKey(soldierType))
				{
					legions[legionName].Add(soldierType, soldierCount);
					if (lastActivity > legionLastActivity[legionName])
					{
						legionLastActivity[legionName] = lastActivity;
					}
				}
				else if (legions.ContainsKey(legionName) && legions[legionName].ContainsKey(soldierType))
				{
					legions[legionName][soldierType] += soldierCount;
					if (lastActivity > legionLastActivity[legionName])
					{
						legionLastActivity[legionName] = lastActivity;
					}
				}
			}
			List<string> commands = Console.ReadLine()
				.Split('\\')
				.Select(x => x)
				.ToList();
			if (commands.Count == 2)
			{
				long activity = long.Parse(commands[0]);
				string soldierType = commands[1];
				foreach (var legion in legions
					.Where(l => l.Value.ContainsKey(soldierType))
					.OrderByDescending(l => l.Value[soldierType]))  //.Sum()
				{
					if (legionLastActivity[legion.Key] < activity)
					{
						Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
					}
				}
			}
			else if (commands.Count == 1)
			{
				string soldierType = commands[0];
				foreach (var legion in legionLastActivity.OrderByDescending(x => x.Value))
				{
					if (legions[legion.Key].ContainsKey(soldierType))
					{
						Console.WriteLine($"{legion.Value} : {legion.Key}");
					}
				}
			}

		}
	}
}
