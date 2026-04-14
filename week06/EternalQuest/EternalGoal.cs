public class EternalGoal :Goal
{
    //Attributes
    //None
    //Consructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    //Methods
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}