public class Circle : Shape
{
    //Attributes
    private double _radius;
    //Constructors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return 3.14159 * (_radius * _radius);
    }
}