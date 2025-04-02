using System;

class Program
{
    static void Main(string[] args)
    {
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
                break;
                case "2": break;
                case "3": break;
                default: break;
            }
        }
    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu:");
    }
}