using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LegendaryFarming
{
	class Program
	{
		static void Main(string[] args)
		{
			string isObtained = "No";
			//keep track of materials and quantities in key-materials dictionary and a junk materials dictionary
			Dictionary<string, int> keyMaterials = new Dictionary<string, int>
			{
				{ "shards", 0 },
				{ "fragments", 0 },
				{ "motes", 0 }
			};
			//keep track og junk in a separate dictionary
			Dictionary<string, int> junk = new Dictionary<string, int>();
			//cast each line of input to lower
			string input = Console.ReadLine().ToLower();
			List<string> inputLine = input
					.Split(' ')                              //new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries
					.Select(str => str)
					.ToList();
			while (true)
			{
				for (int i = 1; i < inputLine.Count; i = i + 2)
				{
					switch (inputLine[i])
					{
						case "shards":
							int oldShards = keyMaterials["shards"];
							keyMaterials["shards"] = oldShards + int.Parse(inputLine[i - 1]); break;
						case "fragments":
							int oldFragments = keyMaterials["fragments"];
							keyMaterials["fragments"] = oldFragments + int.Parse(inputLine[i - 1]); break;
						case "motes":
							int oldMotes = keyMaterials["motes"];
							keyMaterials["motes"] = oldMotes + int.Parse(inputLine[i - 1]); break;
					}
					if (inputLine[i] != "shards"
							&& inputLine[i] != "fragments"
							&& inputLine[i] != "motes"
							&& junk.ContainsKey(inputLine[i]))
					{
						int oldJunk = junk[inputLine[i]];
						junk[inputLine[i]] = oldJunk + int.Parse(inputLine[i - 1]);
					}
					else if (inputLine[i] != "shards"
							&& inputLine[i] != "fragments"
							&& inputLine[i] != "motes"
							&& !junk.ContainsKey(inputLine[i]))
					{
						junk.Add(inputLine[i], int.Parse(inputLine[i - 1]));
					}
					//after each input line check if variables have exceeded limit
					if (keyMaterials["shards"] >= 250)
					{
						isObtained = "Shadowmourne";
						int keyMaterialsOld = keyMaterials["shards"];
						keyMaterials["shards"] = keyMaterialsOld - 250;
					}
					else if (keyMaterials["fragments"] >= 250)
					{
						isObtained = "Valanyr";
						int keyMaterialsOld = keyMaterials["fragments"];
						keyMaterials["fragments"] = keyMaterialsOld - 250;
					}
					else if (keyMaterials["motes"] >= 250)
					{
						isObtained = "Dragonwrath";
						int keyMaterialsOld = keyMaterials["motes"];
						keyMaterials["motes"] = keyMaterialsOld - 250;
					}
					if (isObtained != "No")
					{
						break;
					}
				}
				if (isObtained != "No")
				{
					break;
				}
				else
				{
					input = Console.ReadLine().ToLower();
					inputLine = input
						.Split(' ')                              //new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries
						.Select(str => str)
						.ToList();
				}
			}
			
			

			Console.WriteLine($"{isObtained} obtained!");
			foreach (var keyItem in keyMaterials
				.OrderBy(pair => pair.Key)
				.OrderByDescending(pair => pair.Value)
				.ToDictionary(pair => pair.Key, pair => pair.Value))
				
			{
				Console.WriteLine($"{keyItem.Key}: {keyItem.Value}");
			}
			foreach (var junkItem in junk
				.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value))
			{
				Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
			}
		}
	}
}
