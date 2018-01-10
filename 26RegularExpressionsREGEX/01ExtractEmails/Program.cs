using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01ExtractEmails
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = @"\b(?<=\s)[a-z]+[-._]*[a-z]+@([a-z]+[-]*[a-z]+\.){1}([a-z]+[-]*[a-z]+){1}((\.[a-z]+[-]*[a-z]+))*\b";
			Regex regex = new Regex(pattern);

			MatchCollection matches = regex.Matches(text);
			foreach (Match match in matches)
			{
				Console.WriteLine(match);
			}
		}
	}
}
