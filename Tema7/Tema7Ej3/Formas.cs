using System;

namespace Tema7Ej3
{
	internal class Rectangle : IGeometricShape
	{
		public Rectangle(double rectangleBase, double height) 
		{ 
			Base = rectangleBase;
			Height = height;
			Area = Base * Height;
			Perimeter = 2 * Base + 2 * Height;
		}

		public double Base { get; set; }
		public double Height { get; set; }
		public double Area { get; set; }
		public double Perimeter { get; set; }

		public void ShowDetails()
		{
			Console.WriteLine("Rectángulo\nBase: {0}. Altura: {1}. Área: {2}. Perímetro: {3}", Base, Height, Area, Perimeter);
		}
	}
	internal class Circle : IGeometricShape
	{
	    public Circle(double radius) 
	    {
	        Radius = radius;
	        Area = Math.PI * radius * radius;
	        Perimeter = 2 * Math.PI * radius;
	    }

	    public double Radius { get; set; }
	    public double Area { get; set; }
	    public double Perimeter { get; set; }

	    public void ShowDetails()
	    {
	        Console.WriteLine("Círculo\nRadio: {0}. Área: {1}. Perímetro: {2}", Radius, Area, Perimeter);
	    }
	}
}