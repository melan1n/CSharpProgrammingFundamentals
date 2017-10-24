using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Rectangles
{
	class Program
	{
		public class Rectangle
		{
			public int Left { get; set; }
			public int Top { get; set; }
			public int Width { get; set; }
			public int Height { get; set; }

			public int Right
			{
				get
				{
					return Left + Width;
				}

			}
			public int Bottom
			{
				get
				{
					return Top + Height;
				}
			}

			internal bool IsInside(Rectangle rectB)
			{
				if (this.Bottom <= rectB.Bottom
					&& this.Left >= rectB.Left
					&& this.Top >= rectB.Top
					&& this.Right <= rectB.Right)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public static void Main(string[] args)
		{
			Rectangle rectA = ReadRectangle();
			Rectangle rectB = ReadRectangle();

			Console.WriteLine(rectA.IsInside(rectB) ? "Inside" : "Not inside");
		}

		public static Rectangle ReadRectangle()
		{
			Rectangle result = new Rectangle();
			int[] points = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			result.Left = points[0];
			result.Top = points[1];
			result.Width = points[2];
			result.Height = points[3];
			return result;

		}
	}
}
