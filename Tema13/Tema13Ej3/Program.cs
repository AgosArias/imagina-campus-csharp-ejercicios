using System;
/*
Crear un programa que simule la descarga de varios archivos de manera concurrente.

Cada descarga deberá ejecutarse en su propio Thread.
 
Cada Thread ejecuta un método SimulateDownload que acepta como parámetros el número en la lista 
y el tiempo de espera.
 
La consola debe mostrar el avance de todas las descargas (en la línea correspondiente al número 
de descarga) pintando una "barra de descarga".

Si necesitas sincronizar los hilos, utiliza un Monitor.
 
El programa debe esperar a que todas las descargas se completen y mostrar por consola que han 
finalizado las descargas para finalizar.
*/
using System;

using System.Threading;

namespace Tema13Ej2;

internal class Program
{
	private static object _monitorObject = new object();
	static void Main()
	{
	
		var download1 = new Thread(() => SimulateDownload(0, 500));
		var download2 = new Thread(() => SimulateDownload(1, 650));
		var download3 = new Thread(() => SimulateDownload(2, 200));
		var download4 = new Thread(() => SimulateDownload(3, 1500));		
		download1.Start();
		download2.Start();
		download3.Start();
		download4.Start();		
		download1.Join();
		download2.Join();
		download3.Join();
		download4.Join();		
		Console.WriteLine();
		Console.WriteLine("Descargas finalizadas");
	}

	public static void SimulateDownload(int id, int wait)
	{
		int counter = 0;
		while( counter < 21)
		{
			Monitor.Enter(_monitorObject);

			Console.SetCursorPosition(0,id);
			Console.Write("[");
			for( int i=0; i<counter; i++)
			{
				Console.Write("*");
			}
			for( int i=20;i>counter;i--)
			{
				Console.Write(" ");
			}
			Console.Write("] {0} %", counter * 5);
			counter++;

			Monitor.Exit(_monitorObject);
			Thread.Sleep(wait);
		}
	}
}