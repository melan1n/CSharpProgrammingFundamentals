using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringsAndObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstWord = "Hello";
			string secondWord = "World";
			object concatenation = firstWord + " " + secondWord;
			string thirdVariable = (string)(concatenation);
			Console.WriteLine(thirdVariable);
		}
	}
}
