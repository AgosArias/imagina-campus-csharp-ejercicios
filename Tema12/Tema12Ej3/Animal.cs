using System;

namespace Tema12Ej3
{
    internal class Animal
    {
        public string Name {get; set;}
        public string Species {get; set;}

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }
    }
}