using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> strings = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => x)
				.ToList();
			List<string> newList = new List<string>();
			while (true)
			{
				string commandLine = Console.ReadLine();

				if (commandLine == "3:1")
				{
					break;
				}
				else
				{
					List<string> tokens = commandLine
					
						.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
						.Select(x => x)
						.ToList();
					
					if (tokens[0] == "merge")
					{
						int startIndex = int.Parse(tokens[1]);
						int endIndex = int.Parse(tokens[2]);
						if (startIndex < 0
							&& endIndex > strings.Count - 1)
						{
							startIndex = 0;
							endIndex = strings.Count - 1;
							newList = Merge(strings, startIndex, endIndex);
						}
						else if (startIndex >= 0
							&& startIndex < strings.Count
							&& endIndex >= 0
							&& endIndex < strings.Count)
						{
							newList = Merge(strings, startIndex, endIndex);
						}
						else if (startIndex < 0 
							&& endIndex >= 0
							&& endIndex < strings.Count)
						{
							startIndex = 0;
							newList = Merge(strings, startIndex, endIndex);
						}
						else if (startIndex >= 0 
							&& startIndex < strings.Count
							&& endIndex >= strings.Count)
						{
							endIndex = strings.Count - 1;
							newList = Merge(strings, startIndex, endIndex);
						}
						
						else
						{
							newList = strings;
						}
					}
					else if (tokens[0] == "divide")
					{
						int index = int.Parse(tokens[1]);
						int partitions = int.Parse(tokens[2]);

						newList = Divide(strings, index, partitions);
					}
					strings = newList;
				}
			}
			Console.WriteLine(string.Join(" ", newList));

		}

		private static List<string> Divide(List<string> strings, int index, int partitions)
		{
			StringBuilder sb = new StringBuilder();
				int newLength = strings.Count - 1 + partitions;

			List<string> result = new List<string>();
			for (int i = 0; i < index; i++)
			{
				result.Add(strings[i]);
			}
			string stringToPartition = strings[index];
			if (stringToPartition.Count() % partitions == 0)
			{
				int partLength = stringToPartition.Count() / partitions;
				for (int i = 0; i < stringToPartition.Count(); i = i + partLength)
				{
					result.Add(stringToPartition.Substring(i, partLength));
				}
				
			}
			else if (stringToPartition.Count() % partitions > 0)
			{
				int partFirstLength = stringToPartition.Count() / partitions;
				int partLastLength = partFirstLength + stringToPartition.Count() % partitions;
				int count = 1;
				for (int i = 0; i < stringToPartition.Count(); i = i + partFirstLength)
				{
					if (count > partitions)
					{
						break;
					}
					
					if (i< stringToPartition.Count() - partLastLength)
					{
						result.Add(stringToPartition.Substring(i, partFirstLength));
					}
					else
					{
						result.Add(stringToPartition.Substring(i, partLastLength));
					}
					count++;
					
				}
			}
			for (int i = index + 1; i < strings.Count - 1; i++)
			{
				result.Add(strings[i]);
			}
			return result.ToList();
		}

		private static List<string> Merge(List<string> strings, int startIndex, int endIndex)
		{
			StringBuilder sb = new StringBuilder();

			
				int newLength = strings.Count - (endIndex - startIndex + 1) + 1;
				for (int i = startIndex; i <= endIndex; i++)
				{
					sb.Append(strings[i]);
				}
				List<string> result = new List<string>();
				for (int i = 0; i < startIndex; i++)
				{
					result.Add(strings[i]);
				}
				result.Add(sb.ToString());
				for (int i = endIndex + 1; i < strings.Count; i++)
				{
					result.Add(strings[i]);
				}

				return result.ToList();
			
			
			
							
		}
	}
}
