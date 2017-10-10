using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SplitByWordCasing
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine()
				.Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, 
				StringSplitOptions.RemoveEmptyEntries)
				.Select(str => str)
				.ToList();
			List<string> lowerCase = new List<string>();
			List<string> upperCase = new List<string>();
			List<string> mixedCase = new List<string>();
			foreach (var word in words)
			{
				int countUpper = 0;
				int countLower = 0;
				for (int i = 0; i < word.Length; i++)
				{
					if (char.IsUpper(word[i]))
					{
						countUpper++;
					}
					else if (char.IsLower(word[i]))
					{
						countLower++;
					}
				}
				if (word.Length == countUpper)
				{
					upperCase.Add(word);
				}
				else if (word.Length == countLower)
				{
					lowerCase.Add(word);
				}
				else if(word.Length != countUpper && word.Length != countLower)
				{
					mixedCase.Add(word);
				}
			}
			Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
			Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
			Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
		}
	}
}
