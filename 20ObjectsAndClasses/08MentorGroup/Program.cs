using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08MentorGroup
{
	class Student
	{
		public string Name { get; set; }
		public List<string> Comments { get; set; }
		public List<DateTime> Dates { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();
			while (true)
			{
				string inputDates = Console.ReadLine();
				if (inputDates == "end of dates")
				{
					break;
				}
				else
				{
					string[] inputDatesArr =
						inputDates
						.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
						.Select(s => s)
						.ToArray();
					string name = inputDatesArr[0];
					List<DateTime> dates = new List<DateTime>(inputDatesArr
						.Skip(1)
						.Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture))
						.ToList());
					int studentExisting = students.Where(s => s.Name == name).ToList().Count;
					if (studentExisting != 0)
					{
						List<DateTime> oldDates = students.Where(s => s.Name == name).First().Dates;
						students.Where(s => s.Name == name).First().Dates = oldDates.Concat(dates).ToList();
					}
					else
					{
						Student newStudent = new Student();
						newStudent.Name = name;
						newStudent.Dates = dates;
						newStudent.Comments = new List<string>();
						students.Add(newStudent);
					}
					
				}
			}
			while (true)
			{
				string inputComments = Console.ReadLine();
				if (inputComments == "end of comments")
				{
					break;
				}
				else
				{
					string[] inputCommentsArr =
						inputComments
						.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
						.Select(s => s)
						.ToArray();
					string name = inputCommentsArr[0];
					string comment = inputCommentsArr[1];
					
					int studentExisting = students.Where(s => s.Name == name).ToList().Count;
					if (studentExisting != 0)
					{
						students.Where(s => s.Name == name).First().Comments.Add(comment);
					}
					else
					{
						continue;
					}
				}
			}
			foreach (var student in students.OrderBy(s => s.Name))
			{
				Console.WriteLine($"{student.Name}");
				Console.WriteLine($"Comments:");
				foreach (var comment in student.Comments)
				{
					Console.WriteLine($"- {comment}");
				}
				Console.WriteLine($"Dates attended:");
				foreach (var date in student.Dates.OrderBy(s => s))
				{
					Console.WriteLine($"-- {date:dd/MM/yyyy}");
				}

			}
		}
	}
}
