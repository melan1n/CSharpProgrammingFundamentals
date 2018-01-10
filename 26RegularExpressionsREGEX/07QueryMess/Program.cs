using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07QueryMess
{

	class Program
	{
		static void Main(string[] args)
		{
			//Readline.Split by (&, ?) to get key-value pairs in quary string. Trim()
			string inputLine = Console.ReadLine();
			
			string pattern = @"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)";
			
			Regex regex = new Regex(pattern);
			
			while (inputLine != "END")
			{
				Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

				MatchCollection matches = regex.Matches(inputLine);
				foreach (Match m in matches)
				{
					string[] keyValue = m
						.ToString()
						.Split('=')
						.Select(x => x)
						.ToArray();
					string key = keyValue[0];
					string value = keyValue[1];

					string replacePattern = @"((\+|%20)+)";
					string keyAfterTrim = Regex.Replace(
						key, replacePattern, " ").Trim();
					string valueAfterTrim = Regex.Replace(
						value, replacePattern, " ").Trim();

					if (!result.ContainsKey(keyAfterTrim))
					{
						result.Add(keyAfterTrim, new List<string>() { valueAfterTrim });
					}
					else
					{
						result[keyAfterTrim].Add(valueAfterTrim);
					}
					
				}
				foreach (var pair in result)
				{
					Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
				}
				Console.Write(System.Environment.NewLine);

				inputLine = Console.ReadLine();
			}
			
			
		}
	}
}

