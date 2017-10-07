using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MostFrequentNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();	//read int[n] from console
			ushort[] occurrenceCount = new ushort[ushort.MaxValue];						//create int[ushort.MaxValue] to count occurences of each integer

			for (int i = 0; i < arr.Length; i++)										//loop through arr to set values in occurrenceCount
			{
				occurrenceCount[arr[i]]++;
			}
			 
			ushort[] occurenceCountSortedFromMax = (ushort[])occurrenceCount.Clone();	//clone occurenceCount
			Array.Sort(occurenceCountSortedFromMax);									//sort it
			ushort maxOccurrenceFrequency					
				= occurenceCountSortedFromMax[occurenceCountSortedFromMax.Length-1];	//find max occurence frequency

			for (int i = 0; i < arr.Length; i++)										//loop through arr and print the first element of arr which applied as an index of occurenceCount prodices an element equal to maxOccurenceFrequency
			{
				if (occurrenceCount[arr[i]]== maxOccurrenceFrequency)
					{
						Console.WriteLine(arr[i]);
						break;
					}
			}
		}
	}
}
