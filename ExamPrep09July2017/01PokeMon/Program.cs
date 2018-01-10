using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PokeMon
{
	class Program
	{
		static void Main(string[] args)
		{
			double power = double.Parse(Console.ReadLine());
			double powerNeed = double.Parse(Console.ReadLine());
			int exhaustion = int.Parse(Console.ReadLine());
			double newPower = power;
			int count = 0;
			while (newPower >= powerNeed)
			{
				newPower -= powerNeed;
				count++;
				bool isHalfPower = newPower / power == 0.50 ? true: false;
				if (isHalfPower && exhaustion!=0)
				{
					newPower = (int)newPower / exhaustion; 
				}
			}
			Console.WriteLine(newPower);
			Console.WriteLine(count);
		}
	}
}
