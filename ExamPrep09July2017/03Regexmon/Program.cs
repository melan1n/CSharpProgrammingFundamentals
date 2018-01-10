using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03Regexmon
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			List<string> didi = new List<string>();
			List<string> bojo = new List<string>();
			string didiPattern = @"[^A-Za-z-]+";
			string bojoPattern = @"\b([A-Za-z]+)-([A-Za-z]+)\b";
			Regex regexDidi = new Regex(didiPattern);
			Regex regexBojo = new Regex(bojoPattern);
			while (true)
			{
				int nextStartIndex = 0;
				Match didiMatch = Regex.Match(text, didiPattern);
				if (didiMatch.Success)
				{
					Console.WriteLine(didiMatch.ToString());
					nextStartIndex = didiMatch.Index + didiMatch.Length;
					text = text.Substring(nextStartIndex);
				}
				else
				{
					break;
				}
				Match bojoMatch = Regex.Match(text, bojoPattern);
				if (bojoMatch.Success)
				{
					Console.WriteLine(bojoMatch.ToString());
					nextStartIndex = bojoMatch.Index + bojoMatch.Length;
					text = text.Substring(nextStartIndex);
				}
				else
				{
					break;
				}
			}

		}
	}
}
