using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04New
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<Statistics>> dataSets =
				new Dictionary<string, List<Statistics>>();
			List<Statistics> cache = new List<Statistics>();
			string inputLine = Console.ReadLine();

			while (true)
			{
				if (inputLine == "thetinggoesskrra")
				{
					break;
				}
				else
				{
					List<string> tokens = inputLine
						.Split(new char[] { '-', '>', '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
						.Select(x => x)
						.ToList();
					if (tokens.Count == 1)
					{
						//If you receive only a dataSet you should add it
						if (!dataSets.ContainsKey(tokens[0]))
						{
							dataSets.Add(tokens[0], new List<Statistics>());
							//when dataSet is added, you should check if the cache holds any keys and values referenced to it, and you should add them to the dataSet
							foreach (Statistics statistic in cache.Where(x => x.DataSet == tokens[0]))
							{
								//cache.Remove(statistic);
								dataSets[tokens[0]].Add(statistic);
							}
						}

					}
					else if (tokens.Count == 3)
					{
						//If you receive a dataKey and a dataSize, you should add them to the given dataSet.
						string dataKey = tokens[0];
						int dataSize = int.Parse(tokens[1]);
						string dataSetName = tokens[2];

						if (dataSets.ContainsKey(dataSetName))
						{
							Statistics statistic = new Statistics();
							statistic.DataSet = dataSetName;
							statistic.DataKey = dataKey;
							statistic.DataSize = dataSize;
							dataSets[dataSetName].Add(statistic);
						}
						else if (!dataSets.ContainsKey(dataSetName))
						{
							Statistics statistic = new Statistics();
							statistic.DataSet = dataSetName;
							statistic.DataKey = dataKey;
							statistic.DataSize = dataSize;
							cache.Add(statistic);
						}
					}
				}
				inputLine = Console.ReadLine();
			}
			if (dataSets.Count > 0)
			{
				
				//var dataSetsSorted = dataSets.OrderByDescending(x => x.Value.Sum(y=>y.DataSize));
				//long maxSum = 0;
				string dataSetMaxName = "";
				foreach (var statlist in dataSets.Values.OrderByDescending(x=>x.Sum(y=>y.DataSize)))
				{
					dataSetMaxName = statlist[0].DataSet;
					Console.WriteLine($"Data Set: {statlist[0].DataSet}, Total Size: {statlist.Sum(x=>x.DataSize)}");
					break;
				}
				
				foreach (var statistic in dataSets[dataSetMaxName])
				{
					Console.WriteLine($"$.{statistic.DataKey}");
				}
			}

		}
	}

	internal class Statistics
	{
		public string DataSet { get; set; }
		public string DataKey { get; set; }
		public long DataSize { get; set; }
	}
}
