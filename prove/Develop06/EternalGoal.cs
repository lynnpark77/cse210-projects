public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name,description,points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {_points} in Eternal Goal!!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}