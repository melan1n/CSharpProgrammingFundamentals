using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06ValidUsernames
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{2,24})(?=[\s\/\\(\)]|$)";
			
			Regex regex = new Regex(pattern);

			MatchCollection usernames = regex.Matches(text);
			int maxPairLength = 6;
			string usernameFirst = "";
			string usernameSecond = "";

			for (int i = 1; i < usernames.Count; i++)
			{
				if ((usernames[i].Value.ToString().Length +
					usernames[i-1].Value.ToString().Length) > maxPairLength)
				{
					maxPairLength = usernames[i].Value.ToString().Length +
					usernames[i - 1].Value.ToString().Length;
					usernameFirst = usernames[i-1].Value.ToString();
					usernameSecond = usernames[i].Value.ToString();
				}
			}
			Console.WriteLine(usernameFirst);
			Console.WriteLine(usernameSecond);
		
		}
	}
}
