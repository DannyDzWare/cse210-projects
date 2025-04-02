public class Activity
{
    protected string _name {get; set;} = String.Empty;
    protected string _description {get; set;} = String.Empty;
    protected int _duration {get; set;} = 30;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        string[] chars = {"/", "-", "\\", "|"};

        int secondsCounter = 0;

        while(secondsCounter < seconds)
        {
            for(int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            secondsCounter += 2;
        }

    }
    public void ShowCountdown(int seconds)
    {
        while(seconds > 0)
        {
            Console.Write(seconds.ToString());
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
        return;
    }
}