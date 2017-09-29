using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05WordInPlural
{
	class Program
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine();

			if (word.EndsWith("y"))
			{
				word = word.Remove(word.Length-1);
				Console.WriteLine($"{word}ies");
			}
			else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("o") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
			{
				Console.WriteLine($"{word}es");
			}
			else
			{
				Console.WriteLine($"{word}s");
			}

		}
	}
}
