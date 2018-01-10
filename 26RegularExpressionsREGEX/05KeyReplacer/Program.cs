using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05KeyReplacer
{
	class Program
	{
		static void Main(string[] args)
		{
			string keyString = Console.ReadLine().Trim();
			string textString = Console.ReadLine().Trim();

			string[] keys = keyString
				.Split(new char[] { '|', '<', '\\' })
				.Select(x => x)
				.ToArray();

			string keyStart = keys[0];
			string keyEnd = keys[keys.Length - 1];

			string patternStart = "";
			foreach (var c in keyStart)
			{
				patternStart += "["+c+"]";
			}
			
			string patternEnd = "";
			foreach (var c in keyEnd)
			{
				patternEnd += "[" + c + "]";
			}
			
			Regex regexStartReplace = new Regex(patternStart);
			string textAfterStartReplace = regexStartReplace.Replace(textString, "<");

			Regex regexEndReplace = new Regex(patternEnd);
			string result = regexEndReplace.Replace(textAfterStartReplace, ">");

			string pattern = @"[<].*?[>]";
			Regex regex = new Regex(pattern);

			MatchCollection matches = regex.Matches(result);

			List<string> resultStrings = new List<string>();
			foreach (Match m in matches)
			{
				resultStrings.Add(m.ToString().Trim('<', '>'));
			}
			string finalString = string.Join("", resultStrings);
			if (finalString == "")
			{
				Console.WriteLine("Empty result");
			}
			else
			{
				Console.WriteLine(finalString);
			}
		}
	}
}
