public class PromptGenerator
{
    public List<string> _prompts {get;set;} = new List<string>();

    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    public string GetRandomPrompt()
    {
        if(_prompts.Count > 0)
        {
            int index = new Random().Next(0, _prompts.Count + 1);
            string OUT = _prompts[index];
            return OUT;
        }
        return "";
    }
}