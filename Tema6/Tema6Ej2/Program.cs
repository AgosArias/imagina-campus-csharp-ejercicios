using System;
using System.Collections.Generic;

namespace Tema6Ej2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> albums = new List<string>()
			{
			"Iron Maiden - Fear of the dark",
			"Judas Priest - British steel",
			"Metallica - Ride the lightning",
			"Iron Maiden - Live after death",
			"Moonsorrow - Kivenkantaja",
			"Deep Purple - Burn",
			"Metallica - Master of puppets",
			"Pantera - Cowboys from Hell",
			"Pantera - Vulgar display of power",
			"Iron Maiden - Powerslave",
			"Blind Guardian - Nightfall in Middle-Earth"
		};
	
		albums.Add("Iron Maiden - Killers");
		albums.Insert(9, "Moonsorrow - Verisakeet");

		Console.Write("Intoduce un grupo: ");
		string band = Console.ReadLine();

		int counter = 0;

		foreach (string album in albums)
		{
			if (album.ToLower().StartsWith(band.ToLower()))
			{
				counter++;
			}
		}

		Console.WriteLine("Hay {0} discos del grupo {1}.", counter, band);

			Console.WriteLine();

			albums.Sort();

			foreach (string album in albums)
			{
				Console.WriteLine(album);
			}
		}
	}
}