using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11DifferentNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			if ((b-a) >= 4)
			{
				for (int index1 = a; index1 <= b-4; index1++)
				{
					for (int index2 = index1+1; index2 <= b-3; index2++)
					{
						for (int index3 = index2+1; index3 <= b-2; index3++)
						{
							for (int index4 = index3+1; index4 <= b-1; index4++)
							{
								for (int index5 = index4+1; index5 <= b; index5++)
								{
									Console.WriteLine($"{index1} {index2} {index3} {index4} {index5}");
								}

							}
						}
					}
				}
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
