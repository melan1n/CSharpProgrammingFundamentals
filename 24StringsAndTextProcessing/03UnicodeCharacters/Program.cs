using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03UnicodeCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			var text = Console.ReadLine();
			//StringBuilder builder = new StringBuilder();
			foreach (var c in text)
			{
			Console.Write("\\u" + ((int)c).ToString("x4"));

			}
		}
	}
}
