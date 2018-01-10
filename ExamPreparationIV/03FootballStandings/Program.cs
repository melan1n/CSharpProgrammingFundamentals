using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03FootballStandings
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, TeamStats> table =
				new Dictionary<string, TeamStats>(); 
			string key = Console.ReadLine();
			//const string backslash = "\\";
			//string keyNew = @"\Q"+ key + @"\E";
			//
			//
			//string pattern = 
			//	keyNew
			//	+ "([A-Za-z]+)"
			//	+ keyNew
			//	+ ".*"
			//	+ keyNew
			//	+ "([A-Za-z]+)"
			//	+ keyNew;
			//
			while (true)
			{
				string line = Console.ReadLine();
				if (line == "final")
				{
					break;
				}
				else
				{
					//Regex regex = new Regex(pattern);
					//Match match = regex.Match(line);
					string[] teams = line
						.Split(new string[] { key }, StringSplitOptions.RemoveEmptyEntries)
						.Select(x => x)
						.ToArray();

					string teamA = .Groups[1].Value;
					string teamB = match.Groups[2].Value;

					string scorePattern = @" (\d+):(\d+)";
					Regex regexScore = new Regex(scorePattern);
					Match matchScore = regexScore.Match(line);
					int teamAScore = int.Parse(match.Groups[1].Value);
					int teamBScore = int.Parse(match.Groups[2].Value);


					
				}
			}
		}
	}

	internal class TeamStats
	{
		public int Points { get; set; }
		public int Goals { get; set; }

	}
}
