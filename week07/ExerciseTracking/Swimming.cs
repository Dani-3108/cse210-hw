public class Swimming :Activity
{
    //Attributes
    private double _laps;
    //Constructors
    public Swimming(string date, double minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }
    //Methods
    public override double GetDistance()//in km
    {
        return (_laps * 50) / 1000;
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