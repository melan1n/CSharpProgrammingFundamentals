using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06UserLogs
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
			string user = string.Empty;
			for (int i = 0; i < userIPCount.Count; i++)
			{
				var pair = userIPCount.ElementAt(i);
				KeyValuePair<string, int> nextPair;
				string nextUser = string.Empty;
				if (i != userIPCount.Count - 1)
				{
					nextPair = userIPCount.ElementAt(i + 1);
					nextUser = nextPair.Key.Split('-').ToList()[0];
				}
				string currentUser = pair.Key.Split('-').ToList()[0];
				string ip = pair.Key.Split('-').ToList()[1];
				int count = pair.Value;

				if (currentUser != user && currentUser == nextUser)						               //start block for a new user
				{
					user = currentUser;
					Console.Write($"{user}: " + System.Environment.NewLine);
					Console.Write($"{ip} => {count}, ");
				}
				else if (currentUser != user && currentUser != nextUser)                                //a block for a user with a single IP
				{
					user = currentUser;
					Console.Write($"{user}: " + System.Environment.NewLine);                           
					Console.Write($"{ip} => {count}." + System.Environment.NewLine);
				}
				else if (currentUser == user && currentUser == nextUser)      
				{
					Console.Write($"{ip} => {count}, ");
				}
				else if ((i != userIPCount.Count - 1 && currentUser != nextUser) 
					|| i == userIPCount.Count - 1)														//end a user block
				{
					Console.WriteLine($"{ip} => {count}.");
				}
				
				
			}
			
		}
	}
}
