using System;

namespace Constructor
{
    public class Animal
    {
        // Define properties for the animal
        public string Species { get; set; } 
        public string Name { get; set; }     

        // Constructor that takes species and name as parameters
        public Animal(string species, string name)
        {
            Species = species; 
            Name = name;      
        }

        // Chained constructor that only takes name and defaults species to "Unknown"
        public Animal(string name) : this("Unknown", name) 
        {
            // This constructor allows the creation of an Animal with just a name
            // The species will be set to "Unknown"
        }

        // Method to display information about the animal
        public void DisplayInformation() 
        {
            Console.WriteLine($"Species: {Species}, Name: {Name}"); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable using the "var" keyword to hold an animal's name
            var animalName = "Garfield"; 

            // Create an instance of the Animal class using both species and name
            Animal animal1 = new Animal("Cat", animalName);

            // Create an instance of the Animal class using only the name
            Animal animal2 = new Animal("Charlie"); 

            // Display the information of the created animals
            animal1.DisplayInformation(); 
            animal2.DisplayInformation();
        }
    }
}
