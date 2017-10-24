using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09TeamworkProjects
{
	class Team
	{
		public string Creator { get; set; }
		public string Name { get; set; }
		public List<string> Members { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Team> teams = new List<Team>();
			for (int i = 0; i < n; i++)
			{
				string[] teamCreators = Console.ReadLine()
					.Split('-')
					.Select(s => s)
					.ToArray();
				string newTeamCreator = teamCreators[0];
				string newTeamName = teamCreators[1];
				int teamExists = teams
					.Where(t => t.Name == newTeamName)
					.ToList()
					.Count;
				int creatorExists = teams.Where(t => t.Creator == newTeamCreator).ToList().Count;

				if (teamExists != 0)
				{
					Console.WriteLine($"Team {newTeamName} was already created!");
				}
				else if (creatorExists != 0)
				{
					Console.WriteLine($"{newTeamCreator} cannot create another team!");
				}
				else
				{
					Team newTeam = new Team();
					newTeam.Creator = newTeamCreator;
					newTeam.Name = newTeamName;
					newTeam.Members = new List<string>();
					teams.Add(newTeam);
					Console.WriteLine($"Team {newTeam.Name} has been created by {newTeamCreator}!");
				}
			}
			while (true)
			{
				string[] teamMembers = Console.ReadLine()
					.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
					.Select(s => s)
					.ToArray();
				if (teamMembers[0] == "end of assignment")
				{
					break;
				}
				else
				{
					string newMember = teamMembers[0];
					string team = teamMembers[1];

					bool teamExists = teams.Find(t => t.Name == team) != null ? true : false;
					if (teamExists == false)
					{
						Console.WriteLine($"Team {team} does not exist!");
						continue;
					}
					else
					{
						if (teams.SelectMany(t => t.Members).ToList().Find(m => m == newMember) != null)

						{
							Console.WriteLine($"Member {newMember} cannot join team {team}!");
							continue;
						}
						else if (teams.Select(t => t.Creator).ToList().Find(c => c == newMember) != null)
						{
							Console.WriteLine($"Member {newMember} cannot join team {team}!");
							continue;
						}
						else
						{
							teams.Find(t => t.Name == team).Members.Add(newMember);
						}
					}
				}
			}
			List<Team> teamsWithMembers = new List<Team>(teams
				.Select(t => t)
				.Where(t => t.Members.Count > 0)
				.OrderByDescending(t => t.Members.Count)
				.ThenBy(t => t.Name)
				.ToList());
			List<Team> teamsWithoutMembers = new List<Team>(teams
				.Select(t => t)
				.Where(t => t.Members.Count == 0)
				.OrderBy(t => t.Name)
				.ToList());
			foreach (var team in teamsWithMembers)
			{
				Console.WriteLine($"{team.Name}");
				Console.WriteLine($"- {team.Creator}");
				foreach (var member in team.Members)
				{
					Console.WriteLine($"-- {member}");
				}
			}
			Console.WriteLine($"Teams to disband:");
			foreach (var team in teamsWithoutMembers)
			{
				Console.WriteLine($"{team.Name}");
			}
		}
	}
}
