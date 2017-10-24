using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BookLibrary
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
	class ResultLine										//Objects of this class keep end result (Author - Total)
	{
		public string Author { get; set; }
		public double Total { get; set; }
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
			List<ResultLine> result = myLibrary.Books		//Oder and group results
				.GroupBy(b => b.Author)						//Groups of Book objects by Author
				.Select(rl => new ResultLine				//create a new Resultline object for each of the above groups
				{											//For each group:		
					Author = rl.First().Author,				//Set the Author property to First() - select a single Author property value from the group
					Total = rl.Sum(b => b.Price),			//Sum the Price values for all objects in the group
				}).ToList()
				.OrderByDescending(rl => rl.Total)			//Apply ordering for results
				.ThenBy(rl => rl.Author)
				.ToList();

			foreach (var resultline in result)
			{
				Console.WriteLine($"{resultline.Author} -> {resultline.Total:F2}" );
			}

			Book ReadBook()
			{
				string[] input = Console.ReadLine()
					.Split(' ')
					.Select(s => s)
					.ToArray();
				Book book = new Book();
				book.Author = input[1];
				book.Price = double.Parse(input[5]);
				return book;
			}
		}
	}
}
