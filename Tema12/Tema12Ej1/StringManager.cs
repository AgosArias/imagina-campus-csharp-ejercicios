using System;

namespace Tema12Ej1
{
	class StringManager
	{
		public void PrintToConsole(string text)
		{
			Console.WriteLine(text);
		}

		public void SaveToFile(string text)
		{
			File.WriteAllText("L12E1.txt", text);
		}
	}
}