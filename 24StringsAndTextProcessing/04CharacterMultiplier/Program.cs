using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CharacterMultiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(' ')
				.Select(s => s.Trim())
				.ToArray();
			string a = input[0];
			string b = input[1];

			Console.WriteLine(StringMultiply(a, b));

		}

		private static string StringMultiply(string a, string b)
		{
			string result = "0";
			bool aLongerThanb = a.Length > b.Length ? true : false;

			if (aLongerThanb)
			{
				for (int i = 0; i < b.Length; i++)
				{
					result = (int.Parse(result) + a[i] * b[i]).ToString();
				}
				for (int i = b.Length; i < a.Length; i++)
				{
					result = (int.Parse(result) + a[i]).ToString();
				}
			}
			else
			{
				for (int i = 0; i < a.Length; i++)
				{
					result = (int.Parse(result) + a[i] * b[i]).ToString();
				}
				for (int i = a.Length; i < b.Length; i++)
				{
					result = (int.Parse(result) + b[i]).ToString();
				}
			}
			return result;
		}
	}

}
