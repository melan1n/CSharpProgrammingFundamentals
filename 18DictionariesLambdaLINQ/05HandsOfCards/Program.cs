using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05HandsOfCards
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();

			string input = Console.ReadLine();

			while (input != "JOKER")
			{
				string[] commandArgs = input.Split(':');
				string name = commandArgs[0];
				var cardArgs = commandArgs[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

				if (!people.ContainsKey(name))
				{
					people.Add(name, new Dictionary<string, int>());
					AddCardsToPerson(people[name], cardArgs);
				}
				else
				{
					AddCardsToPerson(people[name], cardArgs);
				}
				input = Console.ReadLine();
			}
			foreach (var person in people)
			{
				Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()}");
			}
			//string commandLine = Console.ReadLine();
			//Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();
			//Dictionary<string, BigInteger> playersScores = new Dictionary<string, BigInteger>();
			//while (commandLine != "JOKER")
			//{
			//	List<string> commandLineList = commandLine
			//		.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
			//		.Select(str => str)
			//		.ToList();
			//	string name = commandLineList[0];
			//	List<string> cards = commandLineList[1]
			//		.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
			//		.Select(str => str.ToUpper())
			//		.ToList();
			//	if (playerCards.ContainsKey(name) == false)
			//	{
			//		playerCards.Add(name, cards);
			//	}
			//	else
			//	{
			//		playerCards[name] = (playerCards[name].Concat(cards)).Distinct().ToList();
			//	}
			//	commandLine = Console.ReadLine();
			//}
			//foreach (var player in playerCards)
			//{
			//	playersScores.Add(player.Key, CountScore(player.Value)); 
			//}
			//foreach (var player in playersScores)
			//{
			//	Console.WriteLine(String.Join(": ", player.Key, player.Value));
			//}
		}

		public static void AddCardsToPerson(Dictionary<string, int> person, string[] cardArgs)
		{
			foreach (var card in cardArgs)
			{
				if (!person.ContainsKey(card))
				{
					person.Add(card, GetCardValue(card));
				}
			}
		}

		public static int GetCardValue(string card)
		{
			int power = 0;

			switch (card[0])
			{
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					power += (int)card[0] - 48;
					break;
				case '1':
					power += 10;
					break;
				case 'J': power += 11; break;
				case 'Q': power += 12; break;
				case 'K': power += 13; break;
				case 'A': power += 14; break;

			}
			switch (card[card.Length-1])
			{
				case 'S':
					power *= 4; break;
				case 'H':
					power *= 3; break;
				case 'D':
					power *= 2; break;
				case 'C':
					power *= 1; break;

			}
			return power;
		}



		//public static BigInteger CountScore(List<string> cards)
		//{
		//	BigInteger result = 0;
		//
		//	BigInteger power = 0;
		//	BigInteger type = 0;
		//
		//	foreach (var card in cards)
		//	{
		//		switch (card[0])
		//		{
		//			case '2': power = 2; break;
		//			case '3': power = 3; break;
		//			case '4': power = 4; break;
		//			case '5': power = 5; break;
		//			case '6': power = 6; break;
		//			case '7': power = 7; break;
		//			case '8': power = 8; break;
		//			case '9': power = 9; break;
		//			case '1': power = 10; break;
		//			case 'J': power = 11; break;
		//			case 'Q': power = 12; break;
		//			case 'K': power = 13; break;
		//			case 'A': power = 14; break;
		//		}
		//		switch (card[card.Length-1])
		//		{
		//			case 'S': type = 4; break;
		//			case 'H': type = 3; break;
		//			case 'D': type = 2; break;
		//			case 'C': type = 1; break;
		//		}
		//		result = result + power * type;
		//	}
		//	
		//	return result;
		//}
	}
}
