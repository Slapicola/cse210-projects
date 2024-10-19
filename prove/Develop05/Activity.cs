public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _description;

    public Activity(string name, int duration, string description)
    {
        _name = name;
        _duration = duration;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine()); //change this later

    }

    public void DisplayFinishedMessage()
    {
        Console.WriteLine("Great Job!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}