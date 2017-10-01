using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08EmployeeData
{
	class Program
	{
		static void Main(string[] args)
		{
			string employeeFirstName = Console.ReadLine();
			string employeeLastName = Console.ReadLine(); ;
			sbyte employeeAge = sbyte.Parse(Console.ReadLine());
			char gender = Console.ReadLine()[0];
			long personalIDNumber = long.Parse(Console.ReadLine());
			long uniqueEmployeeNumber = long.Parse(Console.ReadLine());

			Console.WriteLine($"First name: {employeeFirstName}");
			Console.WriteLine($"Last name: {employeeLastName}");
			Console.WriteLine($"Age: {employeeAge}");
			Console.WriteLine($"Gender: {gender}");
			Console.WriteLine($"Personal ID: {personalIDNumber}");
			Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");




		}
	}
}
