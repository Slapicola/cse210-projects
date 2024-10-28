public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;

    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! you earned {_points} points!");
        return _points;

    }

    public override bool IsComplete()
    {
        return _isComplete;

    }

    public override string GetStringRepresentation()
    {
        return ($"{GetType()}/{_shortName}/{_description}/{_points}/{_isComplete}");
    }
}