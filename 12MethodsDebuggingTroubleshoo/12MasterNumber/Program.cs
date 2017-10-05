using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MasterNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			uint number = uint.Parse(Console.ReadLine());
			for (uint i = 1; i <= number; i++)
			{
				if (IsPalindrome(i) == true && IsSumDivisibleBySeven(i) == true && HoldsEvenDigit(i) == true) 
				{
					Console.WriteLine(i);
				}
			}
		}

		static bool HoldsEvenDigit(uint number)
		{
			bool result = false;
			while (number >= 1)
			{
				byte currentNum = (byte)(number % 10);
				if (currentNum % 2 == 0)
				{
					return true;
				}
				number = (number / 10);
			}
			return result;
		}

		static bool IsSumDivisibleBySeven(uint number)
		{
			bool result = false;
			uint sum = 0;
			while (number >= 1)
			{
				byte currentNum = (byte)(number % 10);
				sum = sum + currentNum;
				number = (number / 10);
			}
			if (sum % 7 == 0)
			{
				result = true;
			}
			return result;
		}

		static bool IsPalindrome(uint number)
		{
			string numberString = number.ToString();
			bool result = true;
			byte digits = (byte)number.ToString().Length;
			for (byte i = 0; i < digits/2; i++)
			{
				if (numberString[i] != numberString[digits - 1 - i])
				{
					return false;
				}
			}
			return result;
		}
	}
}
