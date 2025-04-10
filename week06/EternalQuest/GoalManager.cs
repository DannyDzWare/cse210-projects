using System.Drawing;
using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        
    }

    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        int counter = 1;
        Console.WriteLine("The Goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{counter}: {goal.GetName()}");
            counter++;
        }
    }
    
    public void ListGoalDetails()
    {
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{counter}: {goal.GetDetailsString()}");
            counter++;
        }
        Console.WriteLine("");
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.WriteLine("\t4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        string placeholder = "goal";
        if(type == "4")
        {
            placeholder = "bad habbit";
        }
        
        Console.Write($"What is the name of your {placeholder}? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this {placeholder}? ");
        string points = Console.ReadLine();
        string target = "0";
        string bonus = "0";

        if(type == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description,points);
            _goals.Add(simpleGoal);
        }
        else if(type == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description,points);
            _goals.Add(eternalGoal);
        }
        else if(type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = Console.ReadLine();

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description,points, Convert.ToInt16(target), Convert.ToInt16(bonus));
            _goals.Add(checklistGoal);
        }
        else if(type == "4")
        {
            NegativeGoal eternalGoal = new NegativeGoal(name, description,points);
            _goals.Add(eternalGoal);
        }
        Console.WriteLine("");
    }
   
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = Convert.ToInt16(Console.ReadLine()) - 1;

        _goals[index].RecordEvent();
        int points = _goals[index].GetPoints();
        _score += points;

        if(points > 0)
        {
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else{
            Console.WriteLine($"So sad! You lost {points} points!");
            Console.WriteLine($"You can do better!");
        }
        Console.WriteLine($"You now have {_score} points!\n");
    }
    
    public void SaveGoals()
    {
        Console.Write("Wat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        List<string> fileContent = new List<string>();
        fileContent.Add(_score.ToString());
        foreach(Goal goal in _goals)
        {
            fileContent.Add(goal.GetStringRepresentation());
        }
        File.WriteAllLines(filename, fileContent);
        Console.WriteLine("");
    }
    
    public void LoadGoals()
    {
        Console.Write("Wat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals = new List<Goal>();
        List<string> fileContent = new List<string>();
        fileContent.AddRange(File.ReadAllLines(filename));

        _score = Convert.ToInt32(fileContent[0]);
        for(int i = 1; i < fileContent.Count; i++)
        {
            string[] values = fileContent[i].Split('|');
            if(values[0].ToLower() == "simplegoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(values[1], values[2], values[3], values[4]);
                _goals.Add(simpleGoal);
            }
            else if(values[0].ToLower() == "eternalgoal")
            {
                EternalGoal eternalGoal = new EternalGoal(values[1], values[2], values[3]);
                _goals.Add(eternalGoal);
            }
            else if(values[0].ToLower() == "checklistgoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(values[1], values[2], values[3], Convert.ToInt32(values[4]), Convert.ToInt32(values[5]), Convert.ToInt32(values[6]));
                _goals.Add(checklistGoal);
            }
            else if(values[0].ToLower() == "negativegoal")
            {
                NegativeGoal eternalGoal = new NegativeGoal(values[1], values[2], values[3]);
                _goals.Add(eternalGoal);
            }
        }
        Console.WriteLine("");
    }
}