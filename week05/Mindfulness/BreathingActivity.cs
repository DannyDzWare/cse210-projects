public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        int seconds = 0;
        
        Console.Write($"Breathe in...");
        ShowCountdown(3);
        Console.WriteLine("");
        Console.Write($"Now breathe out...");
        ShowCountdown(3);

        while(seconds < _duration)
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write($"Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("");
            Console.Write($"Now breathe out...");
            ShowCountdown(6);
            seconds += 10;
        }
        Console.WriteLine("");
    }
}