using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08UseYourChainsBuddy
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"<p>(.[^\/]+)<\/p>";      //(?<=<p>).*?(?=<\/p>)

			Regex regex = new Regex(pattern);

			MatchCollection matches = regex.Matches(input);

			List<string> result = new List<string>();
			foreach (Match m in matches)
			{
				string spaceReplacementPattern = @"[^a-z0-9]+";
				string textAfterSpaceReplacement = Regex.Replace(
					m.Groups[1].Value.ToString(), spaceReplacementPattern, " ").Trim();

				string spaceTrimPattern = @"\s{2,}";
				string textAfterSpaceTrim = Regex.Replace(
					textAfterSpaceReplacement, spaceTrimPattern, " ").Trim();

				StringBuilder sb = new StringBuilder();

				foreach (char c in textAfterSpaceTrim)
				{
					if (c >= 'a' && c <= 'm')
					{
						sb.Append(Convert.ToChar(c + 13));
					}
					else if (c >= 'n' && c <= 'z')
					{
						sb.Append(Convert.ToChar(c - 13));
					}
					else
					{
						sb.Append(c);
					}
				}

				string textFinalReversed = sb.ToString();
				result.Add(textFinalReversed);
			}
			Console.WriteLine(string.Join(" ", result));
		}

	}
}
