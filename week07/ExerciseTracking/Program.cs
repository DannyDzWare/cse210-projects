using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>
        {
            new Running(30, 4.8),
            new StationaryBicycles(60, 25.3),
            new Swimming(25, 5)
        };

        System.Console.WriteLine("Here is a summary of the Activities:");
        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}