using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08LettersChangeNumbers
{
	class Program
	{
		public class Tripple
		{
			public char firstChar { get; set; }
			public char secondChar { get; set; }
			//public double number { get; set; }
			public decimal calculated { get; set; }
		}
		static void Main(string[] args)
		{
			List<string> input = new List<string>(
				Console.ReadLine()
				.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
				.Select(x=>x)
				.ToList());

			Dictionary<Tripple, decimal> result = new Dictionary<Tripple, decimal>();

			foreach (var tripple in input)
			{
				Tripple currentTripple = ReadCalcTripple(tripple);
				result.Add(currentTripple, currentTripple.calculated);
			}
			Console.WriteLine($"{result.Values.Sum():F2}");
		}

		private static Tripple ReadCalcTripple(string tripple)
		{
			Tripple result = new Tripple();
			char first = tripple[0];
			char second = tripple[tripple.Length - 1];
			StringBuilder builder = new StringBuilder(tripple.Length);
			builder.Append(tripple);
			builder.Remove(tripple.Length - 1, 1);
			builder.Remove(0, 1);
			decimal num = decimal.Parse(builder.ToString());

			if (first < 97)
			{
				num /= ((decimal)first-64);
			}
			else
			{
				num *= ((decimal)first-96);
			}
			if (second < 97)
			{
				num -= ((decimal)second-64);
			}
			else
			{
				num += ((decimal)second-96);
			}

			result.calculated = num;
			return result;
		}
	}
}
