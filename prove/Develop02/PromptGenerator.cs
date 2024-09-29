public class PromptGenerator //The list isn't working
{
    public List<string> _prompts = new List<string>();
    

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the Lord's hand in my life today?");
        _prompts.Add("What's the most productive thing I did today?");
        _prompts.Add("Did I help someone out today?");
        _prompts.Add("List at least 10 things that make you feel good.");
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[randIndex];
        return randomPrompt;
    }
}