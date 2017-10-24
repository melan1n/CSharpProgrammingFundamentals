using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RandomizeWords
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(' ')
				.ToArray();
			var rnd = new Random();
			for (int i = 0; i < input.Length ; i++)
			{
				int newPos = rnd.Next(input.Length);
				string temp = input[newPos];
				input[newPos] = input[i];
				input[i] = temp;
			}
			foreach (var word in input)
			{
				Console.WriteLine($"{word}");

			}


		}
	}
}
