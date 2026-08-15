using System;

namespace Tema14Ej3;

internal class Program
{
	static void Main()
	{
		var temperatures = new double[] {15.8,12,18.5,37,14.5,20.4,25.8};
		Console.WriteLine(GetTemperaturesPattern(temperatures));
	}

	private static string GetTemperaturesPattern(double[] temperatures)
	{
		return temperatures switch
		{
			[> 28, > 28, > 28, > 28, > 28, > 28, > 28] => "Todos los días fueron calurosos",
			[< 20, > 25, > 25, > 25, > 25, > 25, > 25] => "El lunes fue frío y luego mejoró",
			[.., > 25, > 25] => "El fin de semana hizo bueno",
			[_, _, < 10, ..] => "El miércoles hizo mucho frío",
			[_, .. var midWeek, _, _] when midWeek.Any(t => t > 30) => "A mitad de semana hubo un día caluroso",
			_ => "No hay ningún patrón reconocible"
		};
	}
}

