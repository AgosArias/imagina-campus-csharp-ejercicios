using System;
using System.IO;
using System.Text.Json;

namespace Tema12Ej3
{
    internal class ShelterFiles
    {
        public Shelter _shelter;

        public ShelterFiles(Shelter shelter)
        {
            _shelter = shelter;
            Subscribe(); 
        }

	
        public void Subscribe()
        {
            _shelter.OnAnimalAdded += _shelter_OnAnimalAdded;
            _shelter.OnAnimalAdopted += _shelter_OnAnimalAdopted;
        }
    
        public void Unsubscribe()
        {
            _shelter.OnAnimalAdded -= _shelter_OnAnimalAdded;
            _shelter.OnAnimalAdopted -= _shelter_OnAnimalAdopted;
        }
        private void _shelter_OnAnimalAdopted(Animal animal)
        {
            try
            {
                File.Delete(string.Format("{0}.json", animal.Name));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
        private void _shelter_OnAnimalAdded(Animal animal)
        {
            var jsonAnimal = JsonSerializer.Serialize(animal);
            try
            {
                File.WriteAllText(string.Format("{0}.json", animal.Name), jsonAnimal);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}