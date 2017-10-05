using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EnglishNameOfLastDigit
{
	class Program
	{
		static string EnglishName(char digit)
		{
			string result = "";
			if (digit == '0')
			{
				result = "zero";
			}
			else if (digit == '1')
			{
				result = "one";
			}
			else if (digit == '2')
			{
				result = "two";
			}
			else if (digit == '3')
			{
				result = "three";
			}
			else if (digit == '4')
			{
				result = "four";
			}
			else if (digit == '5')
			{
				result = "five";
			}
			else if (digit == '6')
			{
				result = "six";
			}
			else if (digit == '7')
			{
				result = "seven";
			}
			else if (digit == '8')
			{
				result = "eight";
			}
			else if (digit == '9')
			{
				result = "nine";
			}
			//switch (digit)
			//{
			//	
			//	case 2: result = ""; break;
			//	case 3: result = "three"; break;
			//	case 4: result = "four"; break;
			//	case 5: result = "five"; break;
			//	case 6: result = "six"; break;
			//	case 7: result = "seven"; break;
			//	case 8: result = "eight"; break;
			//	case 9: result = "nine"; break;
			//}
			return result;
		}
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			char lastDigit = number[number.Length-1];
			string englishName = EnglishName(lastDigit);
			Console.WriteLine(englishName);
		}
		
	}
}
