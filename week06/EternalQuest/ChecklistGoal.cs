public class ChecklistGoal :Goal
{
    //Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    //Constructors
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    //Methods
    public override int RecordEvent()
    {
        //adds one each time the user records and activity on the checklist goals
        _amountCompleted++;
        //verifies if the goal is complete and adds the bonus
        if (IsComplete())
        {
            return GetPoints() + _bonus;
        }
        else
        {
            return GetPoints();
        }

    }
    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        //Calls the getDetailsString class from the parent element and just adds the checklist from this goal
        return base.GetDetailsString()+$"--(Completed {_amountCompleted}/{_target} times)";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_amountCompleted},{_target}";
    }
}