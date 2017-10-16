using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06UserLogsLatest
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> ipUser = new Dictionary<string, string>();
			Dictionary<string, int> ipCount = new Dictionary<string, int>();
			
			string line = Console.ReadLine();

			while (line != "end")
			{
				List<string> arguments = line
				.Split(new string[] { "IP=", " message="," user=" }, StringSplitOptions.RemoveEmptyEntries)
				.Select(str => str)
				.ToList();

				string ip = arguments[0];
				string user = arguments[2];
				
				if (!ipUser.ContainsKey(ip))
				{
					ipUser.Add(ip, user);
					ipCount.Add(ip, 1);
				}
				else
				{
					int oldCount = ipCount[ip];
					ipCount[ip] = oldCount + 1;
				}
				line = Console.ReadLine();
			}
			Dictionary<string, string> ipsByAppearanceByUserAscending = ipUser
				.OrderBy(pair => pair.Value)
				.ToDictionary(pair => pair.Key, pair => pair.Value);

			List<string> sortedUsers = ipsByAppearanceByUserAscending.Values.Distinct().ToList();
			foreach (var user in sortedUsers)
			{
				Console.WriteLine($"{user}: ");
				Dictionary<string, string> ipsPerUser = ipUser
					.Where(pair => pair.Value == user)
					.ToDictionary(pair => pair.Key, pair => pair.Value);
				Dictionary<string, int> ipCountsPerUser = new Dictionary<string, int>();
				foreach (var ipPerUser in ipsPerUser)
				{
					ipCountsPerUser.Add(ipPerUser.Key, ipCount[ipPerUser.Key]);
				}
				for (int i = 0; i < ipCountsPerUser.Count-1; i++)
				{
					Console.Write($"{ipCountsPerUser.ElementAt(i).Key} => {ipCountsPerUser.ElementAt(i).Value}, ");
				}
				Console.WriteLine($"{ipCountsPerUser.ElementAt(ipCountsPerUser.Count - 1).Key} => {ipCountsPerUser.ElementAt((ipCountsPerUser.Count - 1)).Value}.");

			}
		}
	}
}
