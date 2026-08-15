using System;

namespace Tema14Ej2;

internal class Program
{
	static void Main()
	{
		Book quixote = new Book("Don Quixote", "Miguel de Cervantes", 583) { Title = "Un Mundo Feliz", Author = "Aldous Huxley", NumberOfPages = 583 };
		Console.WriteLine($"{quixote.Title} ({quixote.Author})");
	}
}