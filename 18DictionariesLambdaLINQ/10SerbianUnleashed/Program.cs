using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SerbianUnleashed
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<string> inputHalves = input.Split(new char[] { '@' }).ToList();
			bool validInput = ValidateInput(input);

			Dictionary<string, Dictionary<string, int>> venueSinger =
					new Dictionary<string, Dictionary<string, int>>();       // venue, dictionary <singer, money (price*tickets)
			while (true)
			{
				if (validInput && input != "End")
				{
					string singer = inputHalves[0].Trim(); // input1 = singer
					List<string> secondHalf = inputHalves[1].Split(' ').Select(str => str).ToList();
					int tickets = int.Parse(secondHalf[secondHalf.Count - 1]);
					int price = int.Parse(secondHalf[secondHalf.Count - 2]);
					int money = tickets * price;                      // input2 translates to - venue (input2.Reverse.skip(2).Reverse), money = (price*ticketcount)
					var venue = String.Join(" ", secondHalf.Take(secondHalf.Count - 2).ToList());

					if (!venueSinger.ContainsKey(venue))
					{
						venueSinger.Add(venue, new Dictionary<string, int>());
						venueSinger[venue].Add(singer, money);
					}
					else if (venueSinger.ContainsKey(venue) && !venueSinger[venue].ContainsKey(singer))   // else if (venue exists & singer not in singer dictionary)
					{
						venueSinger[venue].Add(singer, money);    //add singer and venue + money in second dictionary
					}
					else if (venueSinger.ContainsKey(venue) && venueSinger[venue].ContainsKey(singer))   //else if (singer in singer dictionary 
					{
						int oldMoney = venueSinger[venue][singer];
						venueSinger[venue][singer] = oldMoney + money;   //  - add money to venue
					}
				}
				else if (!validInput && input != "End")
				{
					input = Console.ReadLine();
					inputHalves = input.Split(new char[] { '@' }).ToList();
					validInput = ValidateInput(input);                 //read input
					continue;
				}
				else if (input == "End")
				{
					break;
				}
				input = Console.ReadLine();
				inputHalves = input.Split(new char[] { '@' }).ToList();
				validInput = ValidateInput(input);                 //read input
			}
			//print
			foreach (var venueItem in venueSinger)
			{
				Console.WriteLine($"{venueItem.Key}");
				foreach (var singerMoney in venueSinger[venueItem.Key].OrderByDescending(pair => pair.Value))
				{
					Console.WriteLine($"#  {singerMoney.Key} -> {singerMoney.Value}");
				}
			}
		}

		public static bool ValidateInput(string input)
		{
			bool isValid = true;
			if (input != "End")
			{
				List<string> inputHalves = input.Split(new char[] { '@' }).ToList();

				// split input by @(venue) - get two strings
				//to be valid a line of input should meet:
				if (inputHalves[0][inputHalves[0].Length - 1] != ' '
					|| inputHalves[0].Trim() == string.Empty)   // -first string ends on a white space or // -when trimmed it shoud not be empty string 
				{
					isValid = false;
				}

				List<string> secondHalf = inputHalves[1].Split(' ').Select(str => str).ToList();

				if (secondHalf.Count() < 3
				|| secondHalf.Count() > 5)    // -second string, when split by ' ' should result in 3 to 5 tokens
				{
					isValid = false;
				}
				int parseResult = 0;       // -tryparse index -1 & -2 to confirm they are ints.
				bool parseTickets = int.TryParse(secondHalf[secondHalf.Count - 1], out parseResult);
				bool parsePrice = int.TryParse(secondHalf[secondHalf.Count - 2], out parseResult);

				if (parseTickets == false || parsePrice == false)
				{
					isValid = false;
				}
			}
			
			return isValid;
		}
	}
}
