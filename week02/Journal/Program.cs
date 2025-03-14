using System;

class Program
{
    /* I added another class for the choices.
    * The Data will be stored with semikolon separated, so you can easily save it as a txt or csv.
    *-> That brings also the bonus that you could open and edit it via Excel.
    * I also added the timepoint of the entry as an additional information.
    * When the file doesn't exists, it tells you that.
    * If you don't have entries in your yournal, you will see that as a feedback.
    */
    static void Main(string[] args)
    {
       
       List<string> options = new List<string>{"Write", "Display", "Load", "Save", "Quit"};
       List<string> journalPrompts = new List<string>
       {
            "Who was the most interesting person I interacted with today?",
            "What are three things you’re grateful for today?",
            "Describe a moment from today that made you smile.",
            "What is a personal goal you want to achieve this week?",
            "Write about a challenge you’re facing and how you can overcome it.",
            "What is a lesson you recently learned that changed your perspective?",
            "If you could give advice to your younger self, what would it be?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "Write about a person who has had a positive impact on your life.",
            "What is something you want to improve about yourself and why?",
            "If I had one thing I could do over today, what would it be"
        };

        Choices choices = new Choices(options);
        PromptGenerator promptGenerator = new PromptGenerator(journalPrompts);
        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        string currentChoice = "";
        while(currentChoice.ToLower() != "quit")
        {
            choices.Display();
            currentChoice = choices.GetChoice(Console.ReadLine());

            switch(currentChoice.ToLower())
            {
                case "write": 
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    string text = Console.ReadLine();
                    Entry entry = new Entry(prompt, text);
                    myJournal.AddEntry(entry);
                break;
                case "display": myJournal.DisplayAll(); break;
                case "load": 
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename); break;
                case "save":
                    Console.WriteLine("What is the filename?");
                    string filenameToSave = Console.ReadLine();
                    myJournal.SaveToFile(filenameToSave); break;
            }
        }
    }
}

