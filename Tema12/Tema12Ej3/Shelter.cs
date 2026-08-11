using System;
using System.Collections.Generic;

namespace Tema12Ej3
{
    internal class Shelter
    {
        public delegate void AnimalAddedHandler(Animal animal);
        public delegate void AnimalAdoptedHandler(Animal animal);

        public event AnimalAddedHandler OnAnimalAdded;
        public event AnimalAdoptedHandler OnAnimalAdopted;
        public List<Animal> Pets {get; set;}
        public List<Person> People {get; set;}
        public Shelter()
        {
            People = new List<Person>();
            Pets = new List<Animal> ();
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
            Console.Write("Introduce nombre de la mascota: ");  
            string name = Console.ReadLine();
            Animal animal = SearchAnimal(name);
            if(string.IsNullOrEmpty(animal.Name))
            {
                Console.WriteLine("Animal no encontrado");
                return;
            }     

            person.AdoptPet(animal);
            OnAnimalAdopted?.Invoke(animal);
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
	
        public void AddPet()
        {
            Console.Write("Introduce nombre: ");
            string name = Console.ReadLine();
            Console.Write("Introduce especie: ");
            string species = Console.ReadLine();

            var animal = new Animal(name,species);

            Pets.Add(animal);
            OnAnimalAdded?.Invoke(animal);
        }
        private Animal SearchAnimal(string name)
        {
            Animal animal = new Animal("","");
            foreach(Animal pet in Pets)
            {
                if(pet.Name.ToLower().Equals(name.ToLower()))
                    return pet;
            }
            return animal;
        }
    }
}