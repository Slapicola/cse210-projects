public abstract class Activity
{
    protected string _date;
    protected int _lengthInMins;

    public Activity(string date, int length)
    {
        _date = date;
        _lengthInMins = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_lengthInMins} mins) - Distance: {GetDistance().ToString("0.00")} miles, Speed: {GetSpeed().ToString("0.00")} mph, Pace: {GetPace().ToString("0.00")} min per mile";
    }
}