using System;

namespace Tema14Ej1;

internal class Program
{
	static void Main()
	{
		
	Console.Write("Introduce tu nombre: ");
	var name = Console.ReadLine();
	Console.Write("Introduce tu edad: ");
	var age = int.Parse(Console.ReadLine());
	Console.Write("Introduce tu ciudad: ");
	var city = Console.ReadLine();
	
	string result =
		$"""
		------------------------------------
			" Nombre: {name}     
			" Edad: {age} años    
			" Ciudad: {city}     
		------------------------------------
		""";
	
	Console.WriteLine(result);
	}
}