public class Cycling :Activity
{
    //Attributes
    private double _speed;
    //Constructors
    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    //Methods
    public override double GetDistance()
    {
        return (GetSpeed() / 60) * GetMinutes();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}