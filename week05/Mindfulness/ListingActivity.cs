public class ListingActivity : Activity
{
    private int _count {get;set;} = 0;
    private List<string> _prompts {get;set;} = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountdown(5);
        List<string> userInput = GetListFromUser();
        Console.WriteLine($"You listed {userInput.Count.ToString()} items!");
       
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = _prompts[new Random().Next(0, _prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime start = DateTime.Now;
        while((DateTime.Now - start).TotalSeconds <= _duration)
        {
            userList.Add(Console.ReadLine());
        }
        return userList;
    }
}