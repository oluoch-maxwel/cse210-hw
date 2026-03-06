using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last Name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your Name is {lastName}, {firstName} {lastName}.");
        string fullName = Console.ReadLine();
        
        Console.WriteLine();
    }
}