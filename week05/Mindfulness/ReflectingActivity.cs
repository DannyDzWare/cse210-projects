public class ReflectingActivity : Activity
{
    private List<string> _prompts {get;set;} = new List<string>();
    private List<string> _questions {get;set;} = new List<string>();

    public ReflectingActivity()
    {
         _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        int seconds = 0;
        List<string> tempQuestions = new List<string>();
        tempQuestions.AddRange(_questions);
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountdown(5);

        Console.Clear();

        while(seconds < _duration)
        {
            DisplayQuestions(tempQuestions);
            seconds += 15;
        }
    }
    public string GetRandomPrompt()
    {
        string prompt = _prompts[new Random().Next(0, _prompts.Count)];
        return $"--- {prompt} ---";
    }
    public string GetRandomQuestion()
    {
        string question = _questions[new Random().Next(0, _questions.Count)];
        return $"> {question}";    
    }
    public string GetRandomQuestion(List<string> questions)
    {
        if(questions.Count == 0)
        {
            return $"> No more questions available";    
        }
        else
        {
            string question = questions[new Random().Next(0, questions.Count)];
            questions.Remove(question);
            return $"> {question}";    
        }
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(GetRandomPrompt() + "\n");
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(15);
        Console.WriteLine("");
    }
    public void DisplayQuestions(List<string> questions)
    {
        Console.Write(GetRandomQuestion(questions));
        ShowSpinner(15);
        Console.WriteLine("");
    }
}