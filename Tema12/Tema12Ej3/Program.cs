using System;

namespace Tema12Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shelter shelter = new Shelter();
            shelter.People.Add(new Person("Juan", 55));
            shelter.People.Add(new Person("Antonio", 132));
            shelter.People.Add(new Person("María", 27));
            ShelterFiles files = new ShelterFiles(shelter);
            while (true)
            {
                Console.WriteLine("1. Dar de alta un animal");
                Console.WriteLine("2. Ver todos los animales");
                Console.WriteLine("3. Adoptar animal");
                Console.WriteLine("4. Salir");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        shelter.AddPet();
                        break;
                    case 2:
                        foreach (Animal animal in shelter.Pets)
                        {
                            Console.WriteLine(animal.Name + " (" + animal.Species + ")");
                        }
                        break;
                    case 3:
                        shelter.Adopt();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}