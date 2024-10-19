public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(string name, int duration, string description) : base(name, duration, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you keep going.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("How did you get started?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, type 'ready' to continue.");
        string ready = Console.ReadLine();
        if (ready == "ready")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
        }
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine("");
        }
        
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int randIndex = rand.Next(_prompts.Count);
        string randPrompt = _prompts[randIndex];
        return randPrompt;
    }

    public string GetQuestion()
    {
        Random rand = new Random();
        int randIndex = rand.Next(_questions.Count);
        string randQuestion = _questions[randIndex];
        return randQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--------- {GetPrompt()} -------------\n");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetQuestion()}");
    }
}