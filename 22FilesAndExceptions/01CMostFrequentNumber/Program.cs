using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CMostFrequentNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = new string[]
				{"7 7 7 0 2 2 2 0 10 10 10"};
			File.WriteAllLines("input1C.txt", numbers);
			string text = File.ReadAllText("input1C.txt");
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
			File.WriteAllText("output1C.txt", output.ToString());
		}
	}
}
