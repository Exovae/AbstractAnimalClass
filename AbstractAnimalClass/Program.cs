using System;

abstract class Animal
{
    // Property
    public abstract string Name { get; set; }

    // Additional properties
    public int Age { get; set; }
    public string Sound { get; set; }

    // Methods
    public override string ToString()
    {
        return $"{Name} is {Age} years old and makes a {Sound} sound.";
    }

    public string whatAmI()
    {
        return "I am an animal";
    }

    public abstract string Describe();
}

class Dog : Animal
{
    // Constructor
    public Dog(string name, int age, string sound)
    {
        Name = name;
        Age = age;
        Sound = sound;
    }

    // Default constructor
    public Dog()
    {
        Name = "Betty";
        Age = 0;
        Sound = "Woof";
    }

    // Property implementation
    private string _name;
    public override string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Method implementation
    public override string Describe()
    {
        return $"{Name} is a loyal companion.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Animal animal1 = new Dog("Rufus", 3, "bark");
        Animal animal2 = new Dog();

        // Set properties for animal2
        animal2.Age = 5;
        animal2.Sound = "woof";

        // Call methods
        Console.WriteLine(animal1.Describe());
        Console.WriteLine(animal2.Describe());
        Console.WriteLine(animal1.ToString());
        Console.WriteLine(animal2.ToString());
        Console.WriteLine(animal1.whatAmI());

        Console.ReadLine();
    }
}
