using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Simple Factory Pattern Demo ***\n");
        Console.WriteLine("Enter your choice (0 for Dog, 1 for Tiger):");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            IAnimal animal = SimpleFactory.CreateAnimal(choice);
            animal.Speak();
            animal.Action();
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter 0 or 1.");
        }
    }
}