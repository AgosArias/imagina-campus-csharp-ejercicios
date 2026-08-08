using System;
using System.Collections.Generic;

namespace TemA7Ej1
{
    internal class Shelter
    {
        public Shelter()
        {
            Pets = new List<Animal>();
            People = new List<Person>();
        }
        public List<Animal> Pets {get;set;}
        public List<Person> People {get;set;}
    
        public void AddPet()
        {
            Console.WriteLine("Introduce nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce especie: ");
            string species = Console.ReadLine();

            Pets.Add(new Animal(name, species));
        }

        public void Adopt()
        {
            Console.Write("Introduce DNI del adoptante: ");
            int id = int.Parse(Console.ReadLine());
            Person person = SearchPerson(id);
            if(person.Id == -5)
            {
                Console.WriteLine("Persona no encontrada");
                return;
            }          
            Console.WriteLine("Introduce nombre del animal: ");
            string name = Console.ReadLine();
            Animal animal = SearchAnimal(name);
            if(string.IsNullOrEmpty(animal.Name))
            {
                Console.WriteLine("Animal no encontrado");
                return;
            }  
            person.AdoptPet(animal);
            Pets.Remove(animal);
        }

        private Person SearchPerson(int id)
        {
            Person person = new Person("",-5);
            foreach(Person p in People)
            {
                if(p.Id == id)
                    return p;
            }
            return person;
        }

        private Animal SearchAnimal(string name)
        {
            Animal animal = new Animal("","");
            foreach(Animal a in Pets)
            {
                if(a.Name.ToLower().Equals(name.ToLower()))
                    return a;
            }
            return animal;
        }
    }
}