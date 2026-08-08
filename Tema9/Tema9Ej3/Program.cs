using System;

namespace Tema9Ej3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Introduce precio base: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("El precio con impuestos es: " + CalculateTotalPrice(price));
            }
            catch( NegativePriceException ex)
            {Console.WriteLine(ex.Message);}
            catch(FormatException ex)
            {Console.WriteLine("El valor introducido no es un número correcto.");}
        }

        static double CalculateTax(double basePrice)
        {
            if (basePrice < 0)
            {
                throw new NegativePriceException("Error: el precio no puede ser negativo");
            }
            return basePrice * .21;
        }
        static double CalculateTotalPrice(double price)
        {
            return price + CalculateTax(price);
        }
    }

}