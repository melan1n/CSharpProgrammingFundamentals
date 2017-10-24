using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06BookLibraryModification
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
			int n = int.Parse(Console.ReadLine());
			Library myLibrary = new Library();
			List<Book> Books = new List<Book>();

			for (int i = 0; i < n; i++)
			{
				Book book = ReadBook();
				myLibrary.Books = Books;
				myLibrary.Books.Add(book);
			}
			DateTime cutoffDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

			List<ResultLine> result = myLibrary.Books       //Oder results
				.Where(b => b.ReleaseDate > cutoffDate)     //select only those with Release Date after cutoffDate 
				.Select(rl => new ResultLine                //create a new Resultline object for each Book object
				{                                           //For each resultline:		
					Title = rl.Title,						//Set the Title property 
					ReleaseDate = rl.ReleaseDate,           //Set the Release Date property
				}).ToList()
				.OrderBy(rl => rl.ReleaseDate)				//Apply ordering for results
				.ThenBy(rl => rl.Title)
				.ToList();

			foreach (var resultline in result)
			{
				Console.WriteLine($"{resultline.Title} -> {resultline.ReleaseDate:dd.MM.yyyy}");
			}

			Book ReadBook()
			{
				string[] input = Console.ReadLine()
					.Split(' ')
					.Select(s => s)
					.ToArray();
				Book book = new Book();
				book.Title = input[0];
				book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
				return book;
			}
		}
	}
}

