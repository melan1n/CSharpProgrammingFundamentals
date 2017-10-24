using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BMostFrequentNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = new string[]
				{"2 2 2 2 1 2 2 2"};
			File.WriteAllLines("input1B.txt", numbers);
			string text = File.ReadAllText("input1B.txt");
			int[] textToNumbers = text
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			Dictionary<int, int> maxFrequency = new Dictionary<int, int>();

			for (int i = 0; i < textToNumbers.Length; i++)
			{
				if (!maxFrequency.ContainsKey(textToNumbers[i]))
				{
					maxFrequency.Add(textToNumbers[i], 1);
				}
				else
				{
					maxFrequency[textToNumbers[i]]++;
				}
			}
			int output = maxFrequency.FirstOrDefault(x => x.Value == maxFrequency.Values.Max()).Key;
			Console.WriteLine(output);
			File.WriteAllText("output1B.txt", output.ToString());
		}
	}
}
