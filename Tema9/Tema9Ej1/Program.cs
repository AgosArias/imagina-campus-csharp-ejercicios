using System;

namespace Tema9Ej1
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Introduzca primer número: ");
                int op1 = int.Parse(Console.ReadLine());
                Console.Write("Introduzca segundo número: ");
                int op2 = int.Parse(Console.ReadLine());
                Console.Write("Seleccione operación (+, -, *, /): ");
                char operation = (char)Console.Read();
                double result;
                switch (operation)
                {
                    case '+':
                        result = op1 + op2;
                        break;
                    case '-':
                        result = op1 - op2;
                        break;
                    case '*':
                        result = op1 * op2;
                        break;
                    case '/':
                        result = (double)op1 / op2;
                        break;
                    default:
                        throw new ArgumentException("Operador no valido");
                }
                Console.WriteLine("El resultado de la operación {0} {1} {2} es {3}", op1, operation, op2, result);
            }
            catch (ArgumentException ex) {Console.WriteLine(ex.Message);}
            catch (FormatException ex) {Console.WriteLine("Error: el número introducido no es válido: " + ex.Message);}
            catch (DivideByZeroException ex) {Console.WriteLine(ex.Message);}
            finally {Console.WriteLine("Fin del programa");}
        }
    }

}