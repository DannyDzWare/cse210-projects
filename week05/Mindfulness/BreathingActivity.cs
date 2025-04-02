public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        _duration = Convert.ToInt32(Console.ReadLine());
        int seconds = 0;
        Console.Clear();
        System.Console.WriteLine("Get ready...");
        ShowSpinner(6);
        Console.WriteLine(Environment.NewLine);
        Console.Write($"Breathe in...");
        ShowCountdown(3);
        Console.Write($"Now breathe out...");
        ShowCountdown(3);

        while(seconds < _duration)
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write($"Breathe in...");
            ShowCountdown(4);
            Console.Write($"Now breathe out...");
            ShowCountdown(6);
            seconds += 10;
        }
    }
}