using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			List<string> placeholders = Console.ReadLine()
				.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x)
				.ToList();
			string placeholderPattern = @"([a-zA-Z]+)(.*)\1";
			List<string> matches = new List<string>();
			foreach (Match m in Regex.Matches(text, placeholderPattern))
			{
				string match = m.Groups[2].Value;
				matches.Add(match);
			}
			//string textResult = text;
			for (int i = 0; i < matches.Count; i++)
			{
				int place = text.IndexOf(matches[i]);
				string textResult = text.Remove(place, matches[i].Length).Insert(place, placeholders[i]);
				text = textResult;
				//string textResult = text.Replace(matches[i], placeholders[i]);
				//text = textResult;
			}
			Console.WriteLine(text);
		}
	}
}
