public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name,description,points)
    {

    }

    public override void RecordEvent()
    {
        _amountComplete ++;
        if (IsComplete())
        {
            Console.WriteLine($"");
        }
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}