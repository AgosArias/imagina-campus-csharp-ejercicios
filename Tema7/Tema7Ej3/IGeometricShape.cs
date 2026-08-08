using System;

namespace Tema7Ej3
{
    internal interface IGeometricShape
    {
        public double Area{get;set;}
        public double Perimeter{get;set;}

        public void ShowDetails();
    }
}