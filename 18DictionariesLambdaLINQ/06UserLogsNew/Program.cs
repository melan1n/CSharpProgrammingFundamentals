using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//DON'T SEE WHAT'S WRONG HERE
namespace _06UserLogsNew
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> distinctIpUser = new Dictionary<string, string>();   //dictionary of distinct ip-user pairs
			Dictionary<string, int> ipCount = new Dictionary<string, int>();                //count of emails per IP

			string line = Console.ReadLine();

			while (line != "end")
			{
				List<string> inputList = line
					.Split(new string[] { "IP=", " message=", "user=" }, StringSplitOptions.RemoveEmptyEntries)
					.Select(str => str)
					.ToList();
				string ip = new string(inputList[0].ToCharArray());
				string user = new string(inputList[2].ToCharArray());

				if (distinctIpUser.ContainsKey(ip) == false)
				{
					distinctIpUser.Add(ip, user);
					ipCount.Add(ip, 1);
				}

				else if (distinctIpUser.ContainsKey(ip) == true && distinctIpUser.ContainsKey(ip))
				{
					ipCount[ip] = ipCount[ip] + 1;
				}

				line = Console.ReadLine();
			}
			Dictionary<string, string> ipUserSortedByUser = new Dictionary<string, string>();
			ipUserSortedByUser = distinctIpUser
				.OrderBy(pair => pair.Value)
				.ToDictionary(pair => pair.Key, pair => pair.Value);                            //distinct IP-user - sorted by user

			List<string> users = ipUserSortedByUser.Values.Distinct().ToList();                 //sorted list of distinct users

			foreach (var user in users)
			{
				Console.WriteLine($"{user}: ");
				for (int i = 0; i < ipUserSortedByUser.Count; i++)
				{
					if (i != ipUserSortedByUser.Count - 1 && ipUserSortedByUser.ElementAt(i).Value == user && ipUserSortedByUser.ElementAt(i + 1).Value == user)
					{
						Console.Write($"{ipUserSortedByUser.ElementAt(i).Key} => {ipCount[ipUserSortedByUser.ElementAt(i).Key]}, ");
					}
					else if (i != ipUserSortedByUser.Count - 1 && ipUserSortedByUser.ElementAt(i).Value == user && ipUserSortedByUser.ElementAt(i + 1).Value != user)
					{
						Console.Write($"{ipUserSortedByUser.ElementAt(i).Key} => {ipCount[ipUserSortedByUser.ElementAt(i).Key]}." + System.Environment.NewLine);
					}
					else if (i == ipUserSortedByUser.Count - 1 && ipUserSortedByUser.ElementAt(i).Value == user)
					{
						Console.WriteLine($"{ipUserSortedByUser.ElementAt(i).Key} => {ipCount[ipUserSortedByUser.ElementAt(i).Key]}.");
					}
					else
					{
						continue;
					}
				}


			}

		}
	}
}
