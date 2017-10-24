using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _10BookLibraryModification
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
	class ResultLine                                        //Objects of this class keep end result (Title - Release Date)
	{
		public string Title { get; set; }
		public DateTime ReleaseDate { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("input.txt", "5\r\nLOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00\r\nHobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25\r\nHP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50\r\nHP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00\r\nAC OBowden PenguinBooks 20.11.2009 0395082555 14.00\r\n30.07.1954");
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
				book.Title = input[0];
				book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
				
				myLibrary.Books = Books;
				myLibrary.Books.Add(book);
			}
			DateTime cutoffDate = DateTime.ParseExact(lines[lines.Length-1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

			List<ResultLine> result = myLibrary.Books       //Oder results
				.Where(b => b.ReleaseDate > cutoffDate)     //select only those with Release Date after cutoffDate 
				.Select(rl => new ResultLine                //create a new Resultline object for each Book object
				{                                           //For each resultline:		
					Title = rl.Title,                       //Set the Title property 
					ReleaseDate = rl.ReleaseDate,           //Set the Release Date property
				}).ToList()
				.OrderBy(rl => rl.ReleaseDate)              //Apply ordering for results
				.ThenBy(rl => rl.Title)
				.ToList();

			foreach (var resultline in result)
			{
				File.AppendAllText("output.txt", resultline.Title + " -> " + string.Format("{0:dd.MM.yyyy}", resultline.ReleaseDate) + "\r\n");
			}

			
		}
	}
}
