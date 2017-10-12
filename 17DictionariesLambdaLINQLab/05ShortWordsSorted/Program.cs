using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ShortWordsSorted
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine()
				.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x.ToLower())
				.Distinct()
				.Where(x => x.Length < 5)
				.OrderBy(x => x)
				.ToList();
			Console.WriteLine(String.Join(", ", words));

				
		}
	}
}



