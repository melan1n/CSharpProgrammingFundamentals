using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01CountWorkingDays
{
	class Program
	{
		static void Main(string[] args)
		{
			//DateTime startDate = new DateTime();
			DateTime startDate = DateTime.ParseExact(
				Console.ReadLine()
				, "dd-MM-yyyy"
				, CultureInfo.InvariantCulture);
			DateTime endtDate = DateTime.ParseExact(
				Console.ReadLine()
				, "dd-MM-yyyy"
				, CultureInfo.InvariantCulture);

			int startDateDay = startDate.Day;
			int startDateMonth = startDate.Month;
			int endDateDay = endtDate.Day;
			int endDateMOnth = endtDate.Month;

			List<int[]> bankHolidays = new List<int[]>()
			{new int[] { 1, 1 },
			 new int[] { 3, 3 },
			 new int[] { 1, 5 },
			 new int[] { 6, 5 },
			 new int[] { 24, 5 },
			 new int[] { 6, 9 },
			 new int[] { 22, 9 },
			 new int[] { 1, 11 },
			 new int[] { 24, 12 },
			 new int[] { 25, 12 },
			 new int[] { 26, 12 }
			};
			int countOfWorkingDays = 0;
			for (DateTime i = startDate; i <= endtDate; i = i.AddDays(1))
			{
				int[] dateDayMonth = new int[] { i.Day, i.Month };
				bool isBankHoliday = false;
				for (int j = 0; j < bankHolidays.Count; j++)
				{
					if (dateDayMonth[0] == bankHolidays[j][0]
						&& dateDayMonth[1] == bankHolidays[j][1])
					{
						isBankHoliday = true;
						break;
					}
				}
				if (isBankHoliday == false
					&& i.DayOfWeek != DayOfWeek.Saturday
					&& i.DayOfWeek != DayOfWeek.Sunday)
				{
					countOfWorkingDays++;
				}
			}
			Console.WriteLine(countOfWorkingDays);
		}
	}
}
