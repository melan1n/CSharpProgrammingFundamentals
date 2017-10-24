using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BIndexOfLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] alphabet = new char[26];

			for (int i = 97; i <= 122; i++)
			{
				alphabet[i - 97] = (char)(i);
			}
			char[] input = Console.ReadLine()
				.ToCharArray();
			string[] result = new string[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				result[i] = input[i].ToString() + " -> " + Array.IndexOf(alphabet, input[i]).ToString();

			}
			File.WriteAllText("output2B.txt", "");
			File.AppendAllLines("output2B.txt", result);

		}
	}
}
