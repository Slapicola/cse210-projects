public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(string name, int duration, string description) : base(name, duration, description)
    {
        _prompts.Add("");
        _questions.Add("");

    }

    public void Run()
    {

    }

    public string GetPrompt()
    {
        return "";
    }

    public string GetQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}