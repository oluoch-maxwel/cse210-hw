public class Activity
{
    protected string _activityName;
    protected string _description;
    protected string _duration;

    public Activity(string activityName, string description,string duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void ShowStartingMessage()
    {
        Console.WriteLine($"Starting {_activityName}...");
        Console.WriteLine($"===={_description}===");

        //Ask user for duration,
        Console.WriteLine($"Enter duration of {_activityName} in seconds");
        _duration = Console.ReadLine();

        //Be ready to begin
        Console.WriteLine("Be ready to begin...");

        //Pause for several seconds
        Thread.Sleep(3000);
    }

    public void ShowEndingMessage()
    {
        Console.WriteLine("Well done!");

        Thread.Sleep(3000);

        Console.WriteLine($"You have completed {_activityName} and it took you {_duration} seconds");

    }
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now;
         int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("\r" + spinner[i % spinner.Length]);
            Thread.Sleep(200);
            i++;
        }

       Console.Write("\r "); // clear spinner

    }

    

}