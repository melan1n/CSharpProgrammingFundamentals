using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06UserLogMain
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<string, Dictionary<string, int>> userIPs = new SortedDictionary<string, Dictionary<string, int>>();
			string input = Console.ReadLine();
			while (input != "end")
			{
				List<string> arguments = input
				.Split(new string[] { "IP=", " message", "user=" }, StringSplitOptions.RemoveEmptyEntries)
				.Select(str => str).
				ToList();
				string ip = arguments[0];
				string user = arguments[2];

				if (!userIPs.ContainsKey(user))
				{
					userIPs.Add(user, new Dictionary<string, int>());
					userIPs[user].Add(ip, 1);
				}
				else if (userIPs.ContainsKey(user) && !userIPs[user].ContainsKey(ip))
				{
					userIPs[user].Add(ip, 1);
				}
				else if (userIPs.ContainsKey(user) && userIPs[user].ContainsKey(ip))
				{
					int oldCount = userIPs[user][ip];
					userIPs[user][ip] = oldCount + 1;
				}
				input= Console.ReadLine();
			}
			foreach (var userIP in userIPs)
			{
				Console.WriteLine($"{userIP.Key}:");
				
				for (int i = 0; i < userIPs[userIP.Key].Count - 1; i++)
				{
					Console.Write($"{userIPs[userIP.Key].ElementAt(i).Key} => {userIPs[userIP.Key].ElementAt(i).Value}, ");				 
				}
				Console.Write($"{userIPs[userIP.Key].ElementAt(userIPs[userIP.Key].Count - 1).Key} => {userIPs[userIP.Key].ElementAt(userIPs[userIP.Key].Count - 1).Value}." + System.Environment.NewLine);





			}
		}
	}
}
