using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int numNumber = PromptUserNumber();
        int squared = SquareNumber(numNumber);
        DisplayResult(name, squared);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome Student to CSE210");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter number");
        string numString = Console.ReadLine();
        int numNumber = int.Parse(numString);
        return numNumber;
    }
    static int SquareNumber(int numNumber)
    {
        int square = numNumber * numNumber;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}