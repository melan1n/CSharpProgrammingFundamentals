using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LogsAggregator
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Dictionary<string, Dictionary<string, long>> users = new Dictionary<string, Dictionary<string, long>>();

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();

				string[] arguments = input.Split(' ').ToArray();
				string ip = arguments[0];
				string user = arguments[1];
				long duration = long.Parse(arguments[2]);

				if (!users.ContainsKey(user))
				{
					users.Add(user, new Dictionary<string, long>());
					users[user].Add(ip, duration);
				}
				else
				{
					if (users.ContainsKey(user) && users[user].ContainsKey(ip))
					{
						long oldDuration = users[user][ip];
						users[user][ip] = oldDuration + duration; 
					}
					else if (users.ContainsKey(user) && !users[user].ContainsKey(ip))
					{
						users[user].Add(ip, duration);
					}
				}

			}
			foreach (var user in users.OrderBy(pair => pair.Key))
			{
				Console.Write($"{user.Key}: ");
				Console.Write($"{users[user.Key].Values.Sum()} ");
				Dictionary<string, long> ipsDurationOrderedByUser = users[user.Key].OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
				//{
				Console.Write($"["+string.Join(", ", ipsDurationOrderedByUser.Keys) + $"]" + System.Environment.NewLine);
				//}
			}
		}
	}
}
