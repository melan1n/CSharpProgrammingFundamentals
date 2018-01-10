using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04CubicMessages
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string message = Console.ReadLine();
				if (message == "Over!")
				{
					break;
				}
				else
				{
					int m = int.Parse(Console.ReadLine());
					string pattern = @"^(\d+)([a-zA-Z]" + "{" + m + "})" + @"([^a-zA-Z]+)$";
					Regex regex = new Regex(pattern);
					Match match = regex.Match(message);
					if (match.Success)
					{
						string digitsLeft = match.Groups[1].Value.ToString();
						string text = match.Groups[2].Value.ToString();
						string right = match.Groups[3].Value.ToString();
						StringBuilder sb = new StringBuilder();
						foreach (var c in right)
						{
							if (Char.IsDigit(c))
							{
								sb.Append(c);
							}
						}
						string digitsRight = sb.ToString();
						string indices = string.Concat(digitsLeft, digitsRight);

						Console.Write($"{text} == ");
						StringBuilder sbnew = new StringBuilder();

						foreach (char c in indices)
						{
							if (int.Parse(c.ToString()) > text.Length-1)
							{
								sbnew.Append(' ');
								}
							else
							{
								sbnew.Append(text[int.Parse(c.ToString())]);
							}
							
						}
						if (sbnew.ToString().Trim().Length > 0)
						{
							Console.WriteLine($"{sbnew.ToString().Trim()}");

						}
						

					}
				}
				



			}
		}
	}
}
