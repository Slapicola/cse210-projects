public class Cycling : Activity
{
    private double _cyclingSpeed;

    public Cycling(string date, int length, double cyclingSpeed) : base(date, length)
    {
        _cyclingSpeed = cyclingSpeed;

    }

    public override double GetDistance()
    {
        return _cyclingSpeed * _lengthInMins / 60;

    }

    public override double GetSpeed()
    {
        return _cyclingSpeed;
    }

    public override double GetPace()
    {
        return _lengthInMins / GetDistance();
        
    }
}