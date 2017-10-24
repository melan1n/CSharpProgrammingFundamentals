using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06FixEmails
{
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input.txt", "Ivan\r\nivanivan@abv.bg\r\nPetar Ivanov\r\npetartudjarov@abv.bg\r\nMike Tyson\r\nmyke @gmail.us\r\nstop");

			string[] lines = File.ReadAllLines("input.txt");
			Dictionary<string, string> emailList = new Dictionary<string, string>();
			int count = 1;
			string lastKey = string.Empty;
			for (int i = 0; i < lines.Length-1; i++)
			{
				if (count % 2 == 1)
				{
					if (emailList.ContainsKey(lines[i]) == false)
					{
						emailList.Add(lines[i], string.Empty);
					}
					lastKey = lines[i];
				}
				else
				{
					emailList[lastKey] = lines[i];
				}
				count++;
			}
			emailList = emailList
				.Where(pair => new string(pair.Value.ToCharArray().Reverse().Take(2).ToArray()) != "su"
				&& new string(pair.Value.ToCharArray().Reverse().Take(2).ToArray()) != "ku")
				.ToDictionary(pair => pair.Key, pair => pair.Value);
			foreach (var pair in emailList)
			{
				File.AppendAllText("output.txt", String.Join(" -> ", pair.Key, pair.Value) + "\r\n");
			}
		}
	}
}
