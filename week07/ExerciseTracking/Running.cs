public class Running :Activity
{
    //Attributes
    private double _distance;
    //Constructors
    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    //Methods 
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}