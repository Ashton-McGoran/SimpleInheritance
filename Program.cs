using System;

namespace SimpleInheritance
{
    // Base class
    class Animal
    {
        public string name;
        public int age;
        public string color;
        public double height;
        public double weight;

        // Default constructor
        public Animal()
        {
            name = "";
            age = 0;
            color = "";
            height = 0;
            weight = 0;
        }

        // Parameterized constructor
        public Animal(string name, int age, string color, double height, double weight)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.height = height;
            this.weight = weight;
        }

        // Method to display animal information
        public void DisplayAnimalInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Color: {color}, Height: {height}, Weight: {weight}");
        }
    }

    // Derived class
    class Animal2 : Animal
    {
        // Default constructor for Animal2 class
        public Animal2()
        {
        }

        // Parameterized constructor for Animal2 class
        public Animal2(string name, int age, string color, double height, double weight)
            : base(name, age, color, height, weight)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object of Animal2 class using default constructor
            Animal2 myAnimal = new Animal2();
            Console.WriteLine("Enter animal's name:");
            myAnimal.name = Console.ReadLine();
            Console.WriteLine("Enter animal's age:");
            myAnimal.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter animal's color:");
            myAnimal.color = Console.ReadLine();
            Console.WriteLine("Enter animal's height:");
            myAnimal.height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter animal's weight:");
            myAnimal.weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Animal using default constructor:");
            myAnimal.DisplayAnimalInfo();
            Console.WriteLine();

            // Object of Animal2 class using parameterized constructor
            Console.WriteLine("Enter another animal's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter animal's age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter animal's color:");
            string color = Console.ReadLine();
            Console.WriteLine("Enter animal's height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter animal's weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Animal2 anotherAnimal = new Animal2(name, age, color, height, weight);
            Console.WriteLine("Animal using parameterized constructor:");
            anotherAnimal.DisplayAnimalInfo();
        }
    }
}
