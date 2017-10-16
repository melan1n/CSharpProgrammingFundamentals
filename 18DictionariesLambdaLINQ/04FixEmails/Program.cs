using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FixEmails
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			Dictionary<string, string> emailList = new Dictionary<string, string>();
			int count = 1;
			string lastKey = string.Empty;
			while (line != "stop")
			{
				if (count % 2 == 1)
				{
					if (emailList.ContainsKey(line) == false)
					{
						emailList.Add(line, string.Empty);
					}
					lastKey = line;
				}
				else
				{
					emailList[lastKey] = line;
				}
				line = Console.ReadLine();
				count++;
			}
			emailList = emailList
				.Where(pair => new string (pair.Value.ToCharArray().Reverse().Take(2).ToArray()) != "su"
				&&  new string(pair.Value.ToCharArray().Reverse().Take(2).ToArray()) != "ku")
				.ToDictionary(pair => pair.Key, pair => pair.Value);
			foreach (var pair in emailList)
			{
				Console.WriteLine(String.Join(" -> ", pair.Key, pair.Value));
			}
		}
	}
}
