using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Appearance of IPs is broken. They appear alphabetically but should do in order of appearance.
namespace _06UserLogsNewest
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<string, int> userIPCount = new SortedDictionary<string, int>();
			string line = Console.ReadLine();

			while (line != "end")
			{
				List<string> inputList = line
					.Split(new string[] { "IP=", " message=", "user=" }, StringSplitOptions.RemoveEmptyEntries)
					.Select(str => str)
					.ToList();
				string userIP = new string(inputList[2].ToCharArray())
							  + new string("-".ToCharArray())
							  + new string(inputList[0].ToCharArray());
				if (userIPCount.ContainsKey(userIP) == false)
				{
					userIPCount.Add(userIP, 1);
				}
				else
				{
					userIPCount[userIP] = userIPCount[userIP] + 1;
				}
				line = Console.ReadLine();
			}
			string prevUser = string.Empty;
			for (int i = 0; i < userIPCount.Count; i++)
			{
				var currPair = userIPCount.ElementAt(i);
				KeyValuePair<string, int> nextPair;
				string nextUser = string.Empty;
				if (i != userIPCount.Count - 1)
				{
					nextPair = userIPCount.ElementAt(i + 1);
					nextUser = nextPair.Key.Split('-').ToList()[0];
				}
				string currentUser = currPair.Key.Split('-').ToList()[0];
				string ip = currPair.Key.Split('-').ToList()[1];
				int count = currPair.Value;

				if (currentUser != prevUser && currentUser == nextUser)                              //start block for a new user with many IPs
				{
					Console.Write($"{currentUser}: " + System.Environment.NewLine);
					Console.Write($"{ip} => {count}, ");
				}
				else if (currentUser != prevUser && currentUser != nextUser)                          //block for a user with a single IP
				{
					Console.Write($"{currentUser}: " + System.Environment.NewLine);
					Console.Write($"{ip} => {count}." + System.Environment.NewLine);
				}
				else if (currentUser == prevUser && currentUser == nextUser)                          //mid-line IP of current user
				{
					Console.Write($"{ip} => {count}, ");
				}
				else if (currentUser == prevUser && currentUser != nextUser)                          //last IP of a user with many IPs
				{
					Console.Write($"{ip} => {count}." + System.Environment.NewLine);
				}
				else if (i == userIPCount.Count - 1 && currentUser == prevUser)
				{
					Console.Write($"{ip} => {count}.");
				}
				else if (i == userIPCount.Count - 1 && currentUser != prevUser)
				{
					Console.Write($"{currentUser}: " + System.Environment.NewLine);
					Console.Write($"{ip} => {count}.");
				}
				//else if ((i != userIPCount.Count - 1 && currentUser != nextUser)
				//|| i == userIPCount.Count - 1)                                                      //end a user block
				//{
				//	Console.WriteLine($"{ip} => {count}.");
				//}
				prevUser = currentUser;

			}

		}
	}
}
