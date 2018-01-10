using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MagicExchangeableWords
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

			if (a.Length <= b.Length)                                       //get the shorter string an use it as first argument of method
			{
				Console.WriteLine(IsInterchangeable(a, b).ToString().ToLower());
			}
			else
			{
				Console.WriteLine(IsInterchangeable(b, a).ToString().ToLower());
			}
		}

		private static bool IsInterchangeable(string a, string b)
		{
			bool result = true;
			Dictionary<char, char> dict = new Dictionary<char, char>();    //create a dictionary with keys the chars of the shorter string 'a'

			for (int i = 0; i < a.Length; i++)
			{
				if (!dict.ContainsKey(a[i]) && !dict.ContainsValue(b[i]))
				{
					dict.Add(a[i], b[i]);
				}
				else if (!dict.ContainsKey(a[i]) && dict.ContainsValue(b[i]))
				{
					result = false;
					break;
				}
				else if (dict.ContainsKey(a[i]) && !dict.ContainsValue(b[i]))
				{
					result = false;
					break;
				}
				else if (dict.ContainsKey(a[i]) && dict.ContainsValue(b[i]))
				{
					if (dict[a[i]].Equals(b[i]))
					{
						continue;
					}
					else if (!dict[a[i]].Equals(b[i]))
					{
						result = false;
						break;
					}
				}
			}
			if (result == true)                              //once you've compared up to the length of string 'a' check the rest of the chars in 'b' 
			{
				for (int i = a.Length; i < b.Length; i++)   
				{
					if (!dict.ContainsValue(b[i]))            //if dict does not contain Value b[i]
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}
	}
}
