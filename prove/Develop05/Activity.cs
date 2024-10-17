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

    }

    public void DisplayFinishedMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountdown(int seconds)
    {
        
    }
}