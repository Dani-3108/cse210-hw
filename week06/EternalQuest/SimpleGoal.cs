public class SimpleGoal :Goal
{
    //Attributes 
    private bool _isComplete;
    //Constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    //Methods
    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
    public void SetComplete(bool value)
    {
        _isComplete = value;
    }
}