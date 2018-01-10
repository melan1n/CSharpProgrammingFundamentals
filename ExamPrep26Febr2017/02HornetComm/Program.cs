using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02HornetComm
{
	class Program
	{
		static void Main(string[] args)
		{
			//keep messages in collection (list of Message objects ((0)RecipCode, (1)Message))
			List<Message> messages = new List<Message>();		
			//keep broadcast in collection (list of Broadcast objects (0) Message, (1) Frequency) 
			List<Broadcast> broadcasts = new List<Broadcast>();

			while (true)
			{
				string text = Console.ReadLine();
				if (text == "Hornet is Green")
				{
					break;
				}
				List<string> tokens = ReadLine(text);
				if (IsMessage(tokens))
				{
					Message message = ProcessMessage(tokens);
					messages.Add(message);
				}
				else if (IsBroadcast(tokens))
				{
					Broadcast broadcast = ProcessBroadcast(tokens);
					broadcasts.Add(broadcast);
				}
			}

			Console.WriteLine($"Broadcasts:");
			if (broadcasts.Count == 0)
			{
				Console.WriteLine($"None");
			}
			else
			{
				foreach (var broadcast in broadcasts)
				{
					Console.WriteLine($"{broadcast.Frequency} -> {broadcast.Text}");
				}
			}
			Console.WriteLine($"Messages:");
			if (messages.Count == 0)
			{
				Console.WriteLine($"None");
			}
			else
			{
				foreach (var message in messages)
				{
					Console.WriteLine($"{message.RecipCode} -> {message.Text}");
				}
			}
		}
		

		private static Broadcast ProcessBroadcast(List<string> tokens)
		{
			//add broadcast -> (0) Message, (1) Frequency method with frequency cap->small&small->cap )
			Broadcast broadcast= new Broadcast();
			string frequencyUpDown = tokens[1];
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < frequencyUpDown.Length; i++)
			{
				if (frequencyUpDown[i] >= 97 && frequencyUpDown[i] <= 122)
				{
					sb.Append(Char.ToUpper(frequencyUpDown[i]));
				}
				else
				{
					sb.Append(Char.ToLower(frequencyUpDown[i]));
				}
				
			}
			string frequency = sb.ToString();
			broadcast.Text = tokens[0];
			broadcast.Frequency = frequency;
			return broadcast;
		}

		private static bool IsBroadcast(List<string> tokens)
		{
			//else if first is match for anything but digits && second is a match for digits|letters;
			bool noDigits = true;
			for (int i = 0; i < tokens[0].Length; i++)
			{
				if (Char.IsDigit(tokens[0][i]))
				{
					noDigits = false;
					break;
				}
				else
				{
					continue;
				}
			}

			bool digitsAndLettersOnly = true;
			for (int i = 0; i < tokens[1].Length; i++)
			{
				if (Char.IsDigit(tokens[1][i]) || Char.IsLetter(tokens[1][i]))
				{
					continue;
				}
				else
				{
					digitsAndLettersOnly = false;
					break;
				}
			}
			if (noDigits == true && digitsAndLettersOnly == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static Message ProcessMessage(List<string> tokens)
		{
			//process message line (method with reverse (0)code) add Message to private messages collection
			Message message = new Message();
			string codeReversed = tokens[0];
			StringBuilder sb = new StringBuilder();
			for (int i = codeReversed.Length-1; i >= 0; i--)
			{
				sb.Append(codeReversed[i]);
			}
			string code = sb.ToString();
			message.RecipCode = code;
			message.Text = tokens[1];
			return message;
		}

		private static bool IsMessage(List<string> tokens)
		{
			//if first is match for only digits pattern && second is a match for digits | letters
			bool digitsOnly = true;
			for (int i = 0; i < tokens[0].Length; i++)
			{
				if (Char.IsDigit(tokens[0][i]))
				{
					continue;
				}
				else
				{
					digitsOnly = false;
					break;
				}
			}

			bool digitsAndLettersOnly = true;
			for (int i = 0; i < tokens[1].Length; i++)
			{
				if (Char.IsDigit(tokens[1][i]) || Char.IsLetter(tokens[1][i]))
				{
					continue;
				}
				else
				{
					digitsAndLettersOnly = false;
					break;
				}
			}
			if (digitsOnly == true && digitsAndLettersOnly == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static List<string> ReadLine(string text)  //split by regex "( )<->( )". Return a list of groups1 == first , groups2 = second
		{
			
			List<string> result = new List<string>();
			string patternLine = @"(.+) <-> (.+)";
			Regex regex = new Regex(patternLine);
			Match match = regex.Match(text);
			
			result.Add(match.Groups[1].Value);
			result.Add(match.Groups[2].Value);

			return result;
		}
	}

	internal class Broadcast
	{
		//(0) Message, (1) Frequency
		public string Text { get; set; }
		public string Frequency { get; set; }
	}

	internal class Message
	{ 
		//(0)RecipCode, (1)Text)
		public string RecipCode { get; set; }
		public string Text { get; set; }
	}
}


