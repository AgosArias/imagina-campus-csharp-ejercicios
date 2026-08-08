using System;
using System.Collections.Generic;

namespace Tema6Ej3
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> phrasesQueue = new Queue<string>();
	
		while (true)
		{
			Console.WriteLine("1. Introducir frase");
			Console.WriteLine("2. Imprimir frase");
			Console.WriteLine("3. Número de frases");
			Console.WriteLine("4. Salir");
	
			Console.Write("Seleccione una opción: ");
	
			int option = int.Parse(Console.ReadLine());
	
			switch (option)
			{
				case 1:
					AddPhrase(phrasesQueue);
					break;
				case 2:
					PrintPhrase(phrasesQueue);
					break;
				case 3:
					PrintNumberOfPhrases(phrasesQueue);
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Opción no válida");
					break;
			}
	
			Console.WriteLine("-------------");
		}
	}
	
		public static void AddPhrase(Queue<string> phrasesQueue)
		{
			Console.Write("Introduce la frase: ");
			string phrase = Console.ReadLine();
		
			phrasesQueue.Enqueue(string.Format("[{0}] {1}", DateTime.Now.ToLongTimeString(), phrase));
		}
		
		public static void PrintPhrase(Queue<string> phrasesQueue)
		{
			if(phrasesQueue.Count < 1)
			{
				Console.WriteLine("[No hay frases en la cola]");
			}
			else
			{
				Console.WriteLine(phrasesQueue.Dequeue());
			}
		}
		
		public static void PrintNumberOfPhrases(Queue<string> phrasesQueue)
		{
			Console.WriteLine("La cola contiene en este momento " + phrasesQueue.Count + " frases.");
		}
	}
}