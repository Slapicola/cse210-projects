using System;
//using DateTime;

class Program
{
    static void Main(string[] args)
    {
        Running runningActivity = new Running("29 Oct 2024", 30, 3);
        Cycling cyclingActivity = new Cycling("29 Oct 2024", 45, 25);
        Swimming swimmingActivity = new Swimming("29 Oct 2024", 50, 20);

        List<Activity> _activities = new List<Activity>();

        _activities.Add(runningActivity);
        _activities.Add(cyclingActivity);
        _activities.Add(swimmingActivity);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }



    }
}