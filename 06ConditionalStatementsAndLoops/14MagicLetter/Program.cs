using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14MagicLetter
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstLetter = Convert.ToChar(Console.ReadLine());
			char secondLetter = Convert.ToChar(Console.ReadLine());
			char thirdLetter = Convert.ToChar(Console.ReadLine());

			for (int i = (int)firstLetter; i <= (int)secondLetter; i++)
			{
				for (int j = (int)firstLetter; j <= (int)secondLetter; j++)
				{
					for (int k = (int)firstLetter; k <= secondLetter; k++)
					{
						if (k == thirdLetter || j == thirdLetter || i == thirdLetter)
						{
							continue;
						}
						else
						{
							Console.Write($"{(char)i}{(char)j}{(char)k} ");	
						}
					}
				}
			}
		}
	}
}
