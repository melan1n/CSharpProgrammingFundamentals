using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03RageQuit
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = @"([^0-9]+)([\d]+)";
			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(text);
			StringBuilder strings = new StringBuilder();
			foreach (Match m in matches)
			{
				string key = m.Groups[1].Value.ToUpper();
				int count = int.Parse(m.Groups[2].Value);
				for (int i = 0; i < count; i++)
				{
					strings.Append(key);
				}
			}
			string result = strings.ToString();
			int countUnique = result.Distinct().Count();
			Console.WriteLine($"Unique symbols used: {countUnique}");
			Console.WriteLine($"{result}");
		}
	}
}
