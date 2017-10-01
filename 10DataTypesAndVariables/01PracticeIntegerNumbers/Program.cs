using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PracticeIntegerNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			

			while (line != string.Empty)
			{
				long longNumber = long.Parse(line);
				if (longNumber >= sbyte.MinValue && longNumber <= sbyte.MaxValue)
				{
					sbyte num = (sbyte)longNumber;
					Console.WriteLine(num);
				}
				else if (longNumber >= byte.MinValue && longNumber <= byte.MaxValue)
				{
					byte num = (byte)longNumber;
					Console.WriteLine(num);
				}
				else if (longNumber >= short.MinValue && longNumber <= short.MaxValue)
				{
					short num = (short)longNumber;
					Console.WriteLine(num);
				}
				else if (longNumber >= ushort.MinValue && longNumber <= ushort.MaxValue)
				{
					ushort num = (ushort)longNumber;
					Console.WriteLine(num);
				}
				else if (longNumber >= int.MinValue && longNumber <= int.MaxValue)
				{
					int num = (int)longNumber;
					Console.WriteLine(num);
				}
				else if (longNumber >= uint.MinValue && longNumber <= uint.MaxValue)
				{
					uint num = (uint)longNumber;
					Console.WriteLine(num);
				}
				else if (longNumber >= 0 && (ulong)longNumber < ulong.MaxValue)
				{
					ulong num = (ulong)longNumber;
					Console.WriteLine(num);
				}
				else
				{
					Console.WriteLine(longNumber);
				}
				line = Console.ReadLine();
			}
		}
	}
}
