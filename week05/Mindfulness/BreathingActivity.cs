public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.",
            "0")   
    {
    }

    public void RunActivity()
    {
        ShowStartingMessage();

        // convert _duration (string) to int
        if (!int.TryParse(_duration, out int duration))
        {
            Console.WriteLine("Invalid duration. Please enter a number.");
            return;
        }

        int time = 0;

        while (time < duration)  
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);

            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);

            time += 6;
        }

        ShowEndingMessage();
    }
}