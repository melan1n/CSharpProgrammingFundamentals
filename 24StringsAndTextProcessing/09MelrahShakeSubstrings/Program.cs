using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MelrahShakeSubstrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = Console.ReadLine();

			while (pattern.Length > 0)
			{
				int indexFirst = text.IndexOf(pattern);
				int indexLast = text.LastIndexOf(pattern);
				if (indexFirst != -1
					&& indexLast != -1
					&& indexFirst + pattern.Length <= indexLast)
				{
					StringBuilder sb = new StringBuilder();
					sb.Append(text);
					sb.Remove(indexFirst, pattern.Length);
					sb.Remove(indexLast - pattern.Length, pattern.Length);
					text = sb.ToString();

					Console.WriteLine("Shaked it.");
				}
				else
				{
					break;
				}

				pattern = pattern.Remove(pattern.Length / 2, 1);
			}
			Console.WriteLine("No shake.");
			Console.WriteLine(text);
		}
	}
}
