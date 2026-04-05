using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            "0")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _items = new List<string>();
    }

    public void RunActivity()
    {
        ShowStartingMessage();

        // convert duration
        if (!int.TryParse(_duration, out int duration))
        {
            Console.WriteLine("Invalid duration.");
            return;
        }

        Random rand = new Random();

        // show random prompt
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("Prompt:");
        Console.WriteLine(prompt);

        // countdown before starting
        Console.WriteLine("You may begin in:");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        Console.WriteLine("Start listing items:");

        int time = 0;

        // collect user inputs until time is up
        while (time < duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            _items.Add(item);

            time++; // simple time tracking (1 input ≈ 1 second)
        }

        // show result
        Console.WriteLine($"You listed {_items.Count} items!");

        ShowEndingMessage();
    }
}