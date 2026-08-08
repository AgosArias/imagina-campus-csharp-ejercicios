using System;

namespace Tema7Ej2
{
    internal class Motorbike
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Odometer { get; set; }
        public bool ImperialUnits { get; set; }

	
        public Motorbike(string brand, string model, int odometer, bool imperialUnits)
        {
            Brand = brand;
            Model = model;
            Odometer = odometer;
            ImperialUnits = imperialUnits;
        }

        public Motorbike(string brand, string model) : this(brand, model, 0, false){}

        public static int MilesToKilometers(int miles)
        {
            return (int)(miles * 1.609);
        }

        public void DriveDistance(int distance)
        {
            Odometer += distance;
        }

        public void ShowInfo()
        {
            int distance;
            if (ImperialUnits)
                distance = MilesToKilometers(Odometer);
            else
                distance = Odometer;
            Console.WriteLine("Moto: {0} {1}.\nKilómetros totales: {2}", Brand, Model, distance);
        }
    }
}