using System;
using System.Collections.Generic;

namespace Tema8
{
    class Program
    {
        static void Main()
        {
            List<GeometricShape> shapes = new List<GeometricShape>()
            {
                new Triangle(10),
                new Pentagon(5.5, 3, 8),
                new Circle(7, 1, 1)
            };
            int[] x = {5,-3,12};
            int[] y = {3,-8,16};

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].CalculatePerimeter();
                shapes[i].CalculateArea();
                shapes[i].Move(x[i], y[i]);
                Console.WriteLine("Distancia al origen: " + shapes[i].DistanceToOrigin());
            }
        }
    }
}