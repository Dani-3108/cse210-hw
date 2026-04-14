using System.Dynamic;

public abstract class Goal
{
    //Attributes 
    private string _shortName;
    private string _description;
    private int _points;
    //Constructors
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    //Methods
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_shortName} - ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} - {_description}";
        }
    }
    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

}