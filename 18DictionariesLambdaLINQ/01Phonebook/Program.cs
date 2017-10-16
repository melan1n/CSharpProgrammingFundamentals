using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Phonebook
{
	class Program
	{
		static void Main(string[] args)
		{
			string commandLine = Console.ReadLine();
			string[] commands = commandLine
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x)
				.ToArray();
			string command = commands[0]; 
			Dictionary<string, string> phonebook = new Dictionary<string, string>(); 
			while (command != "END")
			{
				if (command == "A")
				{
					string name = commands[1];
					string phone = commands[2];
					if (phonebook.ContainsKey(name) == true)
					{
						phonebook[name] = phone;
					}
					else
					{
						phonebook.Add(name, phone);
					}
				}
				if (command == "S")
				{
					string name = commands[1];
					if (phonebook.ContainsKey(name) == true)
					{
						Console.WriteLine($"{name} -> {phonebook[name]}");
					}
					else
					{
						Console.WriteLine($"Contact {name} does not exist.");
					}
				}
				commandLine = Console.ReadLine();
				commands = commandLine
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x)
				.ToArray();
				command = commands[0];
			}
		}
	}
}
