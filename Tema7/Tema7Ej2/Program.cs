using System;

namespace Tema7Ej2
{
    class Program
    {
        public static void Main()
        {
            Motorbike harley = new Motorbike("Harley", "Fat Bob", 21860, true);
            Motorbike honda = new Motorbike("Honda", "RC211");

            harley.DriveDistance(500);
            honda.DriveDistance(250);

            harley.ShowInfo();
            Console.WriteLine();
            honda.ShowInfo();
        }
    }
}