using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SieveOfEratosthenes
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			//create a primes bool [] with length n and set all its elements to true
			bool[] primes = new bool[n+1];
			for (int i = 0; i <= n; i++)
			{
				primes[i] = true;
			}
			//set primes[0]=primes[1]=false 
			primes[0] = false;
			primes[1] = false;
			//find next smallest prime with index i in array and set all elements with index 2*i, 3*i, 4*i etc. to false. 
			//Repeat procedure for all elements of array
			if (n < 500)                          //for small n, loop through n
			{
				for (int i = 2; i <= n; i++)
				{
					if (primes[i] == true)
					{
						Console.Write($"{i} ");
						for (int j = 2 * i; j <= n;)
						{
							primes[j] = false;
							j += i;
						}
					}
				}
			}
			else                                   //for large n, loop through Sqrt(n)
			{
				for (int i = 2; i <= Math.Sqrt(n); i++)
				{
					if (primes[i] == true)
					{
						Console.Write($"{i} ");
						for (int j = 2 * i; j <= n;)
						{
							primes[j] = false;
							j += i;
						}
					}
				}
			}
			
		}
	}
}
