using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OddOccurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			//read list (to lower)
			List<string> words = Console.ReadLine()
			.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(x => x.ToLower())
			.ToList();

			//create an empty dictionary
			Dictionary<string, int> occurences = new Dictionary<string, int>();

			//loop through list and fill in dictionary key=WORD, Value=OCcurences
			foreach (var word in words)
			{
				if (occurences.ContainsKey(word) == true)
				{
					//int temp = occurences["word"];
					//occurences["word"] = temp++;
					
					occurences[word]++;

				}
				else
				{
					occurences.Add(word, 1);
				}
			}
			//declare list "result"
			List<string> result = new List<string>();

			//loop through dictionary, remove values % 2 == 0 
			foreach (var pair in occurences)
			{
				if (pair.Value % 2 == 1)
				{
					result.Add(pair.Key);
				}
			}
			//print list
			Console.WriteLine(String.Join(", ", result));
		}
	}
}
