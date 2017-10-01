using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ReverseCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstChar = Console.ReadLine()[0];
			char secondChar = Console.ReadLine()[0];
			char thirdChar = Console.ReadLine()[0];

			Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");
		}
	}
}
