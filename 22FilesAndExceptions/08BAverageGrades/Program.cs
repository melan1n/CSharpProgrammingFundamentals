using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08BAverageGrades
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
			File.WriteAllText("input.txt",
				"6\r\nPetar 3 5 4 3 2 5 6 2 6\r\nMitko 6 6 5 6 5 6\r\nGosho 6 6 6 6 6 6\r\nAni 6 5 6 5 6 5 6 5\r\nIva 4 5 4 3 4 5 2 2 4\r\nAni 5.50 5.25 6.00");
			string[] lines = File.ReadAllLines("input.txt");

			int n = int.Parse(lines[0]);
			List<Student> students = new List<Student>();
			for (int i = 1; i <= n; i++)
			{
				Student student = new Student();
				string[] inputLine = lines[i]
					.Split(' ')
					.Select(s => s)
					.ToArray();
				student.Name = inputLine[0];
				student.Grades = new double[inputLine.Length - 1];
				for (int j = 1; j < inputLine.Length; j++)
				{
					student.Grades[j - 1] = double.Parse(inputLine[j]);
				}

				students.Add(student);
			}
			foreach (var student in students
				.Where(s => s.Average >= 5.00)
				.OrderBy(s => s.Name)
				.ThenByDescending(s => s.Average))
			{
				File.AppendAllText("ouput.txt", student.Name + " -> " + String.Format("{0:0.00}", student.Average) + "\r\n");
			}
		}

	}
}
