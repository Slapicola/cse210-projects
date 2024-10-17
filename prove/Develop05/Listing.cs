public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public Listing(string name, int duration, string description) : base(name, duration, description)
    {
        
    }

    public void Run()
    {

    }

    public void GetPrompt()
    {

    }

    public List<string> GetResponses()
    {
        List<string> _responses = new List<string>();
        return _responses;
        
    }
}