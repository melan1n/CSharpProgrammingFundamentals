using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4AverageGrades
{
	public class Student
	{
		public string Name { get; set; }
		public double[] Grades { get; set; }
		public double Average => Grades.Average();

	}
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Student> students = new List<Student>();
			for (int i = 0; i < n; i++)
			{
				Student student = ReadStudent();
				students.Add(student);
			}
			foreach (var student in students
				.Where(s => s.Average >= 5.00)
				.OrderBy(s => s.Name)
				.ThenByDescending(s => s.Average))
			{
				Console.WriteLine($"{student.Name} -> {student.Average:F2}");
			}
		}

		static Student ReadStudent()
		{
			Student student = new Student();
			string[] inputLine = Console.ReadLine()
				.Split(' ')
				.Select(s => s)
				.ToArray();
			student.Name = inputLine[0];
			student.Grades = new double[inputLine.Length - 1];
			for (int i = 1; i < inputLine.Length; i++)
			{
				student.Grades[i-1] = double.Parse(inputLine[i]);
			}
			return student;
		}
	}
}
