using System;

namespace Tema13Ej2;

internal class Program
{
	static async Task Main()
	{
		List<Task<long>> tasks = new List<Task<long>>();

		for(int i=0; i < 100; i++)
		{
			tasks.Add(Task.Run(() =>Fibonacci(40)));
		}
		do
		{
			var finishedTask = await Task.WhenAny(tasks);
			Console.WriteLine(finishedTask.Result);
			tasks.Remove(finishedTask);
		} while(tasks.Count > 1);

	}
	public static long Fibonacci(int n)
	{
		return n < 2
			? n
			: Fibonacci(n - 1) + Fibonacci(n - 2);
	}
}