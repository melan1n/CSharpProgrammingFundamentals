using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CountTheIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			
			while (true)
			{
				string str = Console.ReadLine();
				int intValue;
				bool parseSuccess = Int32.TryParse(str, out intValue);
				if (parseSuccess == true)
				{
					count++;
				}
				else
				{
					break;
				}
			}
			Console.WriteLine(count);



		}
	}
}
