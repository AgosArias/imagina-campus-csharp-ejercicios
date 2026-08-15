using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tema14Ej2
{
	internal class Book(string title, string author, int numberOfPages)
	{
		public required string Title { get; set; } = title;
		public required string Author { get; set; } = author;
		public required int NumberOfPages { get; set; } = numberOfPages;
	}
}