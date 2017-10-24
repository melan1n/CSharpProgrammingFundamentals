using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09BookLibrary
{
	class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Publisher { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string ISBNNumber { get; set; }
		public double Price { get; set; }
	}
	class Library
	{
		public string Name { get; set; }
		public List<Book> Books { get; set; }
	}
	class ResultLine                                        //Objects of this class keep end result (Author - Total)
	{
		public string Author { get; set; }
		public double Total { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input.txt", "5\r\nLOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00\r\nHobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25\r\nHP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50\r\nHP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00\r\nAC OBowden PenguinBooks 20.11.2009 0395082555 14.00");
			string[] lines = File.ReadAllLines("input.txt");
			int n = int.Parse(lines[0]);
			Library myLibrary = new Library();
			List<Book> Books = new List<Book>();

			for (int i = 1; i <= n; i++)
			{
				string[] input = lines[i]
					.Split(' ')
					.Select(s => s)
					.ToArray();
				Book book = new Book();
				book.Author = input[1];
				book.Price = double.Parse(input[5]);
				
				myLibrary.Books = Books;
				myLibrary.Books.Add(book);
			}
			List<ResultLine> result = myLibrary.Books       //Oder and group results
				.GroupBy(b => b.Author)                     //Groups of Book objects by Author
				.Select(rl => new ResultLine                //create a new Resultline object for each of the above groups
				{                                           //For each group:		
					Author = rl.First().Author,             //Set the Author property to First() - select a single Author property value from the group
					Total = rl.Sum(b => b.Price),           //Sum the Price values for all objects in the group
				}).ToList()
				.OrderByDescending(rl => rl.Total)          //Apply ordering for results
				.ThenBy(rl => rl.Author)
				.ToList();

			foreach (var resultline in result)
			{
				File.AppendAllText("output.txt", resultline.Author + " -> " + string.Format("{0:0.00}", resultline.Total) + "\r\n");
			}

			
		}
	}
}
