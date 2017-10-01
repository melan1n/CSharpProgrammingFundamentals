using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PracticeFloatingPointNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();

			while (line != string.Empty)
			{
				int decimalPlaces = line.Substring(line.IndexOf(".")).Length;
				double longNumber = double.Parse(line);
				if ((float)longNumber >= float.MinValue && (float)longNumber <= float.MaxValue && decimalPlaces < 7)
				{
					float num = (float)longNumber;
					Console.WriteLine($"{num:decimalPlacesF}");
				}
				else
				{
					Console.WriteLine(line);
				}
				line = Console.ReadLine();
			}

		}
	}
}
