using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PracticeCharsAndStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();

			while (line != string.Empty)
			{
				if (line.Length == 1)
				{
					char letter = line[0];
					Console.WriteLine(letter);
				}
				else
				{
					Console.WriteLine(line);
				}
				line = Console.ReadLine();
			}
		}
	}
}
