using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LISNew
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().
				Split(' ')
				.Select(int.Parse)
				.ToList();
			int[] lenLISAtEndIndex = new int[numbers.Count];							//stores length of LIS for each sequence end index of numbers
			int[] prevLISPosition = new int[numbers.Count];								//stores the index of the previous member of LIS
			lenLISAtEndIndex[0] = 1;													//Length of LIS at end index 0 is 1.
			prevLISPosition[0] = -1;													//Previous member of LIS at end index 0 is -1 (does not exist).
			int left = 0;                                                               //the index which stores the leftmost highest value of lenLISAtEndIndex 				
			for (int i = 1; i < numbers.Count; i++)										//loop through numbers list 
			{
				bool isSmallestInList = true;											//anchor variable for smallest number in list
				int[] leftOfPosition = lenLISAtEndIndex.Take(i).ToArray();              //take lenLISAtEndIndex left of current index into an array
				int maxValueIndexInLeftOfPosition = leftOfPosition.Max();				//Find the max value
				left = Array.IndexOf(leftOfPosition, maxValueIndexInLeftOfPosition);    //Find leftmost index of the max value
																						//compare list number at current index with list number at index with LIS
				if (numbers[i] > numbers[left])                                         //A: if current number is bigger 
				{																		
					isSmallestInList = false;																	
					lenLISAtEndIndex[i] = lenLISAtEndIndex[left] + 1;                   //add 1 to previous highest length of LIS and populate lenLISAtEndIndex at current index
				}		
				else if (numbers[i] <= numbers[left])                                   //B: if current number is smaller or equal
				{
					int count = 0;														
					while (count < i)                                                   //loop through all indexes left of current index until you find a number smaller than current
					{
						leftOfPosition[left] = 0;                                           //zero "left" and search for next maximum
						maxValueIndexInLeftOfPosition = leftOfPosition.Max();               //Find the new max value
						left = Array.IndexOf(leftOfPosition, maxValueIndexInLeftOfPosition);//Find leftmost index of the max value
						if (numbers[i] > numbers[left])                                     //A: if current number is bigger 
						{
							isSmallestInList = false;
							lenLISAtEndIndex[i] = lenLISAtEndIndex[left] + 1;               //add 1 to previous highest length of LIS and populate lenLISAtEndIndex at current index
							break;
						}
						count++;
					}
				}
				if (isSmallestInList == true)												//if no number left from current is smaller
				{
					lenLISAtEndIndex[i] = 1;                                                //lenLISAtEndIndex = 1 (i.e. new LIS)	
					prevLISPosition[i] = -1;												//no previous member of the LIS
				}
				else if (isSmallestInList == false)                                         //if other numbers left from current are smaller
				{
					prevLISPosition[i] = left;												//set previous member index = "left"
				}
			}
			List<int> longestIncreasingSubsequence = new List<int>();						//empty list to store LIS
			int lenLIS = lenLISAtEndIndex.Max();											//Find length of LIS
			int currentEndIndex = Array.IndexOf(lenLISAtEndIndex, lenLIS);					//Find left most index which is an end index of LIS
			longestIncreasingSubsequence.Add(numbers[currentEndIndex]);						//Add list number on that index to LIS 

			int prevIndex = prevLISPosition[currentEndIndex];								//variable for prev member Index -> set to current index after the member has been added to result
			while (prevIndex >= 0)															//go back to find previous member indexes until we hit value -1.
			{
				longestIncreasingSubsequence.Add(numbers[prevIndex]);						//add number at previous index to LIS
				prevIndex = prevLISPosition[prevIndex];										//set previous index to current value
			}
			longestIncreasingSubsequence.Reverse();											//reverse result LIS
			Console.WriteLine(String.Join(" ", longestIncreasingSubsequence));				//print out LIS



		}
	}
}
