public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _numLaps = laps;

    }

    public override double GetDistance()
    {
        return _numLaps * 50 / 1000 * 0.62;

    }

    public override double GetSpeed()
    {
        return GetDistance() / _lengthInMins * 60;

    }

    public override double GetPace()
    {
        return _lengthInMins / GetDistance();
        
    }
}