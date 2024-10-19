public class Breathing : Activity
{
    public Breathing(string name, int duration, string description) : base(name, duration, description)
    {

    }


    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountdown(5);
            Console.WriteLine("");
        }

    }
}