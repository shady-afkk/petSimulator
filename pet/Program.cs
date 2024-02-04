using System;

class VirtualPet
{
    private string name;
    private int age;
    private int health;
    private int hunger;

    public VirtualPet(string name)
    {
        this.name = name;
        age = 0;
        health = 100;
        hunger = 0;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{name} is {age} years old.");
        Console.WriteLine($"{name} has {health} health.");
        Console.WriteLine($"{name} has {hunger} hunger.");
    }

    public void Play()
    {
        if (age >= 3)
        {
            Console.WriteLine($"{name} is too old to play. :(");
            return;
        }

        Console.WriteLine($"{name} is playing. :D");
        health += 10;
        hunger += 5;
    }

    public void Feed()
    {
        if (hunger <= 0)
        {
            Console.WriteLine($"{name} is not hungry. :D");
            return;
        }

        Console.WriteLine($"{name} is being fed. :D");
        health += 10;
        hunger -= 10;
    }

    public void Sleep()
    {
        if (age < 3)
        {
            Console.WriteLine($"{name} is too young to sleep. :(");
            return;
        }

        Console.WriteLine($"{name} is sleeping. Zzz!!!");
        health += 10;
        hunger += 5;
    }

    public void Grow()
    {
        age++; //age increases by 1
        health -= 10;
        hunger -= 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Virtual Pet simulator application!");
        Console.Write("Please enter your pet's name: ");
        string name = Console.ReadLine();

        VirtualPet pet = new VirtualPet(name);

        while (true)
        {
            Console.WriteLine("Please select an option from the options below:");
            Console.WriteLine("1. Show status");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Feed");
            Console.WriteLine("4. Sleep");
            Console.WriteLine("5. Quit");
            Console.Write("Enter the number of your option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    pet.ShowStatus();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.Feed();
                    break;
                case 4:
                    pet.Sleep();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again now.");
                    break;
            }

            pet.Grow();
        }
    }
}
