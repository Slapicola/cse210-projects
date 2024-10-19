public class Listing : Activity
{
    private int _count; //count of num items that were listed
    private List<string> _prompts = new List<string>();

    public Listing(string name, int duration, string description) : base(name, duration, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        
    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        GetPrompt();
        Console.Write("You may begin in: \n");
        ShowCountdown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        
    }

    public void GetPrompt()
    {
        Random rand = new Random(); 
        int randIndex = rand.Next(_prompts.Count);
        string randPrompt = _prompts[randIndex];
        Console.WriteLine($"----- {randPrompt} -----");
    }
}