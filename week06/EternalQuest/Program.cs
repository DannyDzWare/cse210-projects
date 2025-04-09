using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice = "";
        Console.WriteLine("Hello World! This is the EternalQuest Project.\n");

        GoalManager goalManager = new GoalManager();

        while(menuChoice != "6")
        {
            goalManager.DisplayPlayerInfo();
            DisplayMenu();
            menuChoice = Console.ReadLine();

            switch(menuChoice)
            {
                case "1": goalManager.CreateGoal(); break;
                case "2": goalManager.ListGoalDetails(); break;
                case "3": break;
                case "4": break;
                case "5": break;
                default: break;
            }
        }
    }

    static void DisplayMenu()
    {
        System.Console.WriteLine("Menu Options:");
        System.Console.WriteLine("\t1. Create New Goal");
        System.Console.WriteLine("\t2. List Goals");
        System.Console.WriteLine("\t3. Save Goals");
        System.Console.WriteLine("\t4. Load Goals");
        System.Console.WriteLine("\t5. Record Event");
        System.Console.WriteLine("\t6. Quit");
        System.Console.Write("Select a choice from the menu:");
    }
}