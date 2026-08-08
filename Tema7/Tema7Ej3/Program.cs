using System;

namespace Tema7Ej3
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			List<IGeometricShape> shapesList = new List<IGeometricShape>()
			{
				new Circle(3.25),
				new Circle(132),
				new Circle(10.47),
				new Rectangle(4, 10),
				new Rectangle(5.5, 25),
				new Rectangle(12, 1.75)
			};
		
			foreach (var shape in shapesList)
			{
				shape.ShowDetails();
				Console.WriteLine();
			}
		}
	}
}