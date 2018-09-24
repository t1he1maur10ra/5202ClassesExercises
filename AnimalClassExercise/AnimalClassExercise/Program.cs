using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassExercise
{
    class Animal
    {
        //Private properties for the animals name and sound.
        string name, sound;

        //Default getters and setters for the properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        //Constructor
        public Animal (string _name, string _sound)
        {
            Name = _name;//Accessing the Name setter
            Sound = _sound;//Accessing the Sound setter
        }

        //AnimalSays method that concantinated the animals name and the sound it makes together and returns them as a string.
        public string AnimalSays()
        {
            return "The " + Name + " says " + Sound;//Using the properties getters.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for the animal and its sound and store the in appropriate variables.
            Console.Write("Please enter the animals type ie. Cow, Chicken, Duck: ");
            string animalType = Console.ReadLine();
            Console.Write("Please enter the sound the animal makes: ");
            string animalSound = Console.ReadLine();

            //Create an Animal object using the constructor and filling it with the variables obtained from the user.
            Animal animal1 = new Animal(animalType, animalSound);

            //Display the animal object back to the user using the animalSays method
            Console.WriteLine(animal1.AnimalSays());
        }
    }
}
