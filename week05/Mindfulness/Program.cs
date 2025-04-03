using System;

/* 
    As an exceeding task I inserted a counter which tells you in the end how many of each activities you were doing.
    I also added a temporary questions list in the reflecting Activity to ensure, that all questions are only asked once.
*/
class Program
{
    static void Main(string[] args)
    {
        int[] activityCounter = {0, 0, 0};

        string userInput = "5";

        while (userInput != "4")
        {
            ShowMenu();
            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1": 
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                    activityCounter[0]++;
                break;
                case "2": 
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                    activityCounter[1]++;
                break;
                case "3": 
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    activityCounter[2]++;
                break;
                default: break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"You made {activityCounter[0].ToString()} Breathing Activities, {activityCounter[1].ToString()} Reflecting Activities, {activityCounter[2].ToString()} Listing Activities.");
        Thread.Sleep(3000);
    
    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu:");
    }
}