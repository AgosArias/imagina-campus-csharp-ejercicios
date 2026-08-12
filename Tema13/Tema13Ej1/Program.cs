using System;

namespace Tema13Ej1;

internal class Program
{
	static void Main()
	{
		var t1 = Task.Run(async () =>
		{
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine(DateTime.Now.ToLongTimeString());
				await Task.Delay(1000);
			}
		});

		Random rnd = new Random(DateTime.Now.Millisecond);
		var t2 = Task.Run(async () =>
		{
			for(int i = 0; i < 40; i++)
			{
				Console.WriteLine(rnd.Next(100));
				await Task.Delay(250);
			}
		});
		var t3 = Task.Run(async () =>
		{
			for(int i = 0; i < 20; i++)
			{
				Console.WriteLine("Tarea 3");
				await Task.Delay(500);
			}
		});
		t1.Wait();
		t2.Wait();
		t3.Wait();

	}

}