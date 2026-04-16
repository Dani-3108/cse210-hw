public abstract class Activity
{
    //Attributes
    private string _date;
    private double _minutes;
    //Constructors
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    //Methods
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetDate()} {this.GetType().Name} ({GetMinutes()} min)- Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1}kph, Pace: {GetPace():F1} min per km";
    }

    public double GetMinutes()
    {
        return _minutes;
    }
    public string GetDate()
    {
        return _date;
    }

}