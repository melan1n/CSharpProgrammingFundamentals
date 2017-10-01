using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CenturiesToNanoSeconds
{
	class Program
	{
		static void Main(string[] args)
		{
			int centuries = int.Parse(Console.ReadLine());
			ulong years = (ulong)centuries * 100;
			ulong days = (ulong)(years * 365.2422);
			ulong hours = days * 24;
			ulong minutes = hours * 60;
			ulong seconds = minutes * 60;
			ulong milliseconds = seconds * 1000;
			ulong microseconds = milliseconds * 1000;
			double nanoseconds = (double)microseconds * 1000;

			Console.WriteLine($"{centuries} centuries = " +
				$"{years} years = " +
				$"{days} days = " +
				$"{hours} hours = " +
				$"{minutes} minutes = " +
				$"{seconds} seconds = " +
				$"{milliseconds} milliseconds = " +
				$"{microseconds} microseconds = " +
				$"{nanoseconds:0} nanoseconds");
		}
	}
}
