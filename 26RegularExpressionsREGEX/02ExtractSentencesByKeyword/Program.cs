using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02ExtractSentencesByKeyword
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine().Trim();
			string text = Console.ReadLine();
			string pattern = @"([^.!?]* " + word + @" [^.?!]*?)([\.?!])";
			

			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(text);

			foreach (Match m in matches)
			{
				Console.WriteLine((m.Groups[1]).ToString().TrimStart());
			}

		}
	}
}
