using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select choice: ");

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Running Breathing Activity...");
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
            }
            else if (option == 2)
            {
                Console.WriteLine("Running Reflecting Activity...");
                ReflectionActivity activity = new ReflectionActivity();
                activity.RunActivity();
            }
            else if (option == 3)
            {
                Console.WriteLine("Running Listing Activity...");
                ListingActivity activity = new ListingActivity();
                activity.RunActivity();
            }

        } while (option != 4);

        Console.WriteLine("Goodbye!");
    }
}