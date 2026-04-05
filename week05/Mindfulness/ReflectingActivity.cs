using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompt;
    private List<string> _question;

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.",
            "0")
    {
        _prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _question = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunActivity()
    {
        ShowStartingMessage();

        if (!int.TryParse(_duration, out int duration))
        {
            Console.WriteLine("Invalid duration.");
            return;
        }

        Random rand = new Random();

        // Show random prompt
        string prompt = _prompt[rand.Next(_prompt.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter when ready...");
        Console.ReadLine();

        int time = 0;

        while (time < duration)
        {
            string question = _question[rand.Next(_question.Count)];
            Console.WriteLine(question);

            Thread.Sleep(3000); // pause (spinner can replace this)

            time += 3;
        }

        ShowEndingMessage();
    }
}