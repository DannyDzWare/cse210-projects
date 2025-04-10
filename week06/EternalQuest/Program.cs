using System;
using System.Diagnostics;


/*
    As Exceeding requirement I added negative goals. They are fully integrated.
    That means you can save and load them too.
    You can give the points for them in negative or positive form, but it will always remove them from score.
    Also in the createGoal section the word goal will be replaced with bad habbits, if negative Goal is chosen.
    When I record a negative goal the output phrase changed and a small sentence of motivation will be shown additionally.
*/
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
                case "3": goalManager.SaveGoals(); break;
                case "4": goalManager.LoadGoals(); break;
                case "5": goalManager.RecordEvent(); break;
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
        System.Console.Write("Select a choice from the menu: ");
    }
}