using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IndexOfLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			//create an array containing all letters from the alphabet (a-z)
			int aCode = (int)'a';
			int zCode = (int)'z';
			char[] alphabet = new char[zCode - aCode + 1];
			
			for (int i = 0; i <= zCode-aCode; i++)
			{
				alphabet[i] = (char)(i+aCode);
			}
			
			string word = Console.ReadLine();                   //Read a lowercase word from the console
																
			foreach (var character in word)                     //print the index of each of its letters in the letters array
			{
				Console.WriteLine($"{character} -> {Array.IndexOf(alphabet, character)}"); 
			}
		}
	}
}
