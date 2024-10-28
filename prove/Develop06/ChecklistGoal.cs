public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, bool isComplete, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! you earned {_points + _bonus}!");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! you earned {_points} points!");
            return _points;
        }

    }

    public override bool IsComplete()
    {
        return _isCompleted;

    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Times Completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        return ($"{GetType()}/{_shortName}/{_description}/{_points}/{_isCompleted}/{_bonus}/{_target}/{_amountCompleted}");
        
    }
}