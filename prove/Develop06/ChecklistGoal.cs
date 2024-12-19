public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {

    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {

    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}