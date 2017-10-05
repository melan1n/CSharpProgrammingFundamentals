using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18DebugSequenceOfCommands
{
	class Program
	{
		private const char ArgumentsDelimiter = ' ';

		public static void Main()
		{
			int sizeOfArray = int.Parse(Console.ReadLine());   //read count of elements of array

			BigInteger[] array = Console.ReadLine()					//parse input line to array of type long[]
				.Split(ArgumentsDelimiter)
				.Select(BigInteger.Parse)
				.ToArray();

			string commandLine = Console.ReadLine();                //'command' is command + parameters. It should be parsed!!!
			string[] commandLineArray = commandLine.Split(ArgumentsDelimiter).Select(str=>str).ToArray();
			string command = commandLineArray[0];
			int[] args = new int[2];
			args[0] = int.Parse(commandLineArray[1]);
			args[1] = int.Parse(commandLineArray[2]);

			while (!command.Equals("stop"))						//'over' becomes 'stop'.
			{
				//string line = Console.ReadLine().Trim();        //'line' is command + parameters. It should be parsed to command and args (int[2])!!!
				//int[] args = new int[2];						
				
				commandLineArray = commandLine.Split(ArgumentsDelimiter).Select(str => str).ToArray();
				command = commandLineArray[0];

				if (command.Equals("add") ||                    //program will never enter this
					command.Equals("subtract") ||
					command.Equals("multiply"))
				{
					//string[] stringParams = line.Split(ArgumentsDelimiter);
					//args[0] = int.Parse(stringParams[0]);
					//args[1] = int.Parse(stringParams[1]);
					args = new int[2];
					args[0] = int.Parse(commandLineArray[1]);
					args[1] = int.Parse(commandLineArray[2]);
					PerformAction(array, command, args);
				}
				else
				{
					PerformAction(array, command, args);
				}
				if (command != "stop")
				{
					PrintArray(array);
					Console.WriteLine();                //'\n'
				}
				else
				{
					break;
				}
				commandLine = Console.ReadLine();
			}
		}
		
		static void PerformAction(BigInteger[] arr, string action, int[] args)
		{
			//long[] array = arr.Clone() as long[];
			int pos = args[0];
			int value = args[1];

			switch (action)								//program will never enter here as 'action' also includes arguments
			{
				case "multiply":
					arr[pos-1] *= (BigInteger)value;
					break;
				case "add":
					arr[pos-1] += (BigInteger)value;
					break;
				case "subtract":
					arr[pos-1] = arr[pos-1] - (BigInteger)value;
					break;
				case "lshift":
					ArrayShiftLeft(arr);
					break;
				case "rshift":
					ArrayShiftRight(arr);
					break;
			}
		}

		private static void ArrayShiftRight(BigInteger[] array)
		{
			BigInteger temp = array[array.Length - 1];
			for (int i = array.Length - 1; i >= 1; i--)
			{
				array[i] = array[i - 1];
			}
			array[0] = temp;
		}

		private static void ArrayShiftLeft(BigInteger[] array)
		{
			BigInteger temp = array[0];
			for (int i = 0; i <= array.Length - 2; i++)
			{
				array[i] = array[i + 1];
			}
			array[array.Length-1] = temp;
		}

		private static void PrintArray(BigInteger[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}
