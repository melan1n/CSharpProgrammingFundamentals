using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MostFrequentNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = new string[]
				{"4 1 1 4 2 3 4 4 1 2 4 9 3"};
			File.WriteAllLines("input1A.txt", numbers);
			string text = File.ReadAllText("input1A.txt");
			int[] textToNumbers = text
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			Dictionary<int, int> maxFrequency= new Dictionary<int, int>();
			
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
			File.WriteAllText("output1A.txt", output.ToString());
		}
	}
}
