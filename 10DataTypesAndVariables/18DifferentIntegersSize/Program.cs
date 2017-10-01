using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DifferentIntegersSize
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			sbyte sbyteResult;
			byte byteResult;
			short shortResult;
			ushort ushortResult;
			int intResult;
			uint uintResult;
			long longResult;

			bool fitsSbyte = sbyte.TryParse(line, out sbyteResult);
			bool fitsByte = byte.TryParse(line, out byteResult);
			bool fitsShort = short.TryParse(line, out shortResult);
			bool fitsUshort = ushort.TryParse(line, out ushortResult);
			bool fitsInt = int.TryParse(line, out intResult);
			bool fitsUint = uint.TryParse(line, out uintResult);
			bool fitsLong = long.TryParse(line, out longResult);

			if (fitsSbyte == true || fitsByte == true || fitsShort == true || fitsUshort == true || fitsInt == true || fitsUint == true || fitsLong == true)
			{
				Console.WriteLine($"{line} can fit in:");
				if (fitsSbyte == true)
				{
					Console.WriteLine($"* sbyte");
				}
				if (fitsByte == true)
				{
					Console.WriteLine($"* byte");
				}
				if (fitsShort == true)
				{
					Console.WriteLine($"* short");
				}
				if (fitsUshort == true)
				{
					Console.WriteLine($"* ushort");
				}
				if (fitsInt == true)
				{
					Console.WriteLine($"* int");
				}
				if (fitsUint == true)
				{
					Console.WriteLine($"* uint");
				}
				if (fitsLong == true)
				{
					Console.WriteLine($"* long");
				}
			}
			else
			{
				Console.WriteLine($"{line} can't fit in any type");
			}
		}
	}
}
