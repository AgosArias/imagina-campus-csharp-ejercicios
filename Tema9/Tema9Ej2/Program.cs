using System;

namespace Tema9Ej2
{
    class Program
    {
        static void Main()
        {
            Queue<string> phrasesQueue = new Queue<string>();
            while(true)
            {
                Console.WriteLine("1. Introducir frase");
                Console.WriteLine("2. Imprimir frase");
                Console.WriteLine("3. Número de frases");
                Console.WriteLine("4. Salir");

                Console.Write("Seleccione una opción: ");
                int option;
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("La opción introducida no es un número válido: " + ex.Message);
                    continue;
                }
                switch (option)
                {
                    case 1:
                        AddPhrase(phrasesQueue);
                        break;
                    case 2:
                        try { PrintPhrase(phrasesQueue);}
                        catch (InvalidOperationException ex) {Console.WriteLine("[No hay frases en la cola]");}
                        break;
                    case 3:
                        PrintNumberOfPhrases(phrasesQueue);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.WriteLine("------------");
            }
        }
        public static void AddPhrase(Queue<string> phrasesQueue)
        {
            string phrase = Console.ReadLine();
            phrasesQueue.Enqueue(string.Format("[{0}] {1}", DateTime.Now.ToLongTimeString(), phrase));
        }
        public static void PrintPhrase(Queue<string> phrasesQueue)
        {
            Console.Write(phrasesQueue.Dequeue());
        }

        public static void PrintNumberOfPhrases(Queue<string> phrasesQueue)
        {
                Console.WriteLine("La cola contiene en este momento " + phrasesQueue.Count + " frases.");
        }
    }

}