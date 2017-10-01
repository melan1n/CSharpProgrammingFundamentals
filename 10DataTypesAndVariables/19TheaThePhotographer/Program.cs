using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19TheaThePhotographer
{
	class Program
	{
		static void Main(string[] args)
		{
			int allPictures = int.Parse(Console.ReadLine());
			int filterTimePerPic = int.Parse(Console.ReadLine());
			int filterFactor = int.Parse(Console.ReadLine());
			int uploadTimePerPic = int.Parse(Console.ReadLine());

			long secondsToComplete = ((long)allPictures * filterTimePerPic) + (long)Math.Ceiling(((decimal)allPictures * (decimal)filterFactor / 100)) * uploadTimePerPic;

			long days = secondsToComplete/(24 * 60 * 60);
			long secondsBeyondDays = secondsToComplete % (24 * 60 * 60);
			int hours = (int)secondsBeyondDays / (60 * 60);
			int minutes = ((int)secondsBeyondDays % (60 * 60)) / 60;
			int seconds = (int)secondsBeyondDays - hours * 3600 - minutes*60;

			Console.WriteLine($"{days}:{hours:#00}:{minutes:#00}:{seconds:#00}");
			
		}
	}
}
