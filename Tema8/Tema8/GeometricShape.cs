using System;
using System.Drawing;

namespace Tema8
{
	public abstract class GeometricShape
	{
		public double Area { get; protected set; }
		public double Perimeter { get; protected set; }
		public Point Center { get; protected set; }

		public GeometricShape() { Center = new Point(0, 0); }
		public GeometricShape(int x, int y) { Center = new Point(x, y); }
		public abstract void CalculateArea();
		public abstract void CalculatePerimeter();
		public void Move(double x, double y)
		{
			Center = new Point(Center.X + (int)x, Center.Y + (int)y);
		}
		public double DistanceToOrigin()
		{
			return Math.Sqrt(
				Math.Pow(Center.X, 2) +
				Math.Pow(Center.Y, 2)
				);
		}
	}

	public abstract class RegularPolygon : GeometricShape
	{
		public int NumberOfSides { get; set; }
		public double SideLength { get; set; }

		public RegularPolygon(int numberOfSides, double sideLength) : base()
		{
			NumberOfSides = numberOfSides;
			SideLength = sideLength;
		}
		public RegularPolygon(int numberOfSides, double sideLength, int x, int y) : base(x, y)
		{
			NumberOfSides = numberOfSides;
			SideLength = sideLength;
		}
		public override void CalculatePerimeter()
		{
			Perimeter = NumberOfSides * SideLength;
			Console.WriteLine($"Perimeter: {Perimeter}");
		}
	}

	public class Circle : GeometricShape
	{
		public double Radius { get; set; }

		public Circle(double radius)
			: base()
		{
			Radius = radius;
		}

		public Circle(double radius, int x, int y)
			: base(x, y)
		{
			Radius = radius;
		}
		public override void CalculateArea()
		{
			Area = Math.PI * Math.Pow(Radius, 2);
			Console.WriteLine($"Area: {Area}");
		}
		public override void CalculatePerimeter()
		{
			Perimeter = 2 * Math.PI * Radius;
			Console.WriteLine($"Perimeter: {Perimeter}");
		}


	}

	public class Triangle : RegularPolygon
	{
		public Triangle(double sideLength)
			: base(3, sideLength)
		{
		}

		public Triangle(double sideLength, int x, int y)
			: base(3, sideLength, x, y)
		{
		}
		public override void CalculateArea()
		{
			Area = Math.Sqrt(3) / 4 * Math.Pow(SideLength, 2);
			Console.WriteLine($"Area: {Area}");
		}

	}
	public class Pentagon : RegularPolygon
	{
		public Pentagon(double sideLength)
			: base(5, sideLength)
		{
		}

		public Pentagon(double sideLength, int x, int y)
			: base(5, sideLength, x, y)
		{
		}
		public override void CalculateArea()
		{
			Area = Math.Pow(SideLength, 2) * 1.72;
			Console.WriteLine($"Area: {Area}");
		}
	}
}