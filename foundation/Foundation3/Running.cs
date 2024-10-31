public class Running : Activity
{
    private double _runningDistance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _runningDistance = distance;

    }

    public override double GetDistance()
    {
        return _runningDistance;

    }

    public override double GetSpeed()
    {
        return _runningDistance / _lengthInMins * 60;

    }

    public override double GetPace()
    {
        return _lengthInMins / _runningDistance;

    }
}