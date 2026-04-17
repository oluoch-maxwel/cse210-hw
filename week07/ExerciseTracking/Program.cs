class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new Running(new DateTime(2026, 04, 17), 30, 3.0f));
        exercises.Add(new StationaryBike(new DateTime(2026, 04, 17), 45, 20f));
        exercises.Add(new Swimming(new DateTime(2026, 04, 17), 40, 30f));

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.ToString());
        }
    }
}