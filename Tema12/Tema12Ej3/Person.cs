using System.Collections.Generic;
using System;

namespace Tema12Ej3
{
    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Animal> Pets { get; set; }
        public Person(string name,int id)
        {
            Name = name;
            Id = id;
            Pets = new List<Animal>();
        }
        public void AdoptPet(Animal pet)
        {
            Pets.Add(pet);
            Console.WriteLine("Mascota {0} adoptada por {1}\n", pet.Name, Name);
        }
    }
}