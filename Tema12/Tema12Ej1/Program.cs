using System;

namespace Tema12Ej1
{
	internal class Program
	{
		public delegate void PhraseDelegate(string phrase);
		static void Main()
		{
			Console.Write("Introduce una frase: ");
			string phrase = Console.ReadLine();
			phrase = phrase.ToUpper();

			Console.WriteLine("¿Desea imprimir por (c)onsola o guardar a (f)ichero? Seleccione una opción (c/f): ");
			char option = (char)Console.Read();

			StringManager stringManager = new StringManager();
			PhraseDelegate phraseDelegate;
			
			if(option == 'c' ||  option == 'C')
			{
				phraseDelegate = stringManager.PrintToConsole;
			}
			else if(option == 'f' || option == 'F')
			{
				phraseDelegate = stringManager.SaveToFile;
			}
			else
			{
				Console.WriteLine("Opción no válida");
				return;
			}
			
			phraseDelegate(phrase);
		}
	}
}