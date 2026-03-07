using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int number;
        int myGuess;

        do
        {
            Random randomGenerator = new Random();
            number = randomGenerator.Next(1, 11);
            Console.WriteLine(number);

            Console.Write("What is your guess? ");
            string userString = Console.ReadLine();
            myGuess = int.Parse(userString);

            string result = "";

            if (number > myGuess)
            {
                result = "Higher";
            }
            else if (number < myGuess)
            {
                result = "Lower";
            }
            else
            {
                result = "You guessed it right!";
            }

            Console.WriteLine(result);

        } while (myGuess != number);
    }
}