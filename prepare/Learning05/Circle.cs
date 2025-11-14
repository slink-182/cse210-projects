public class Circle : Shape
{
    private double _radius;
    
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;

    }

    //set methods
    public override double GetArea()
    {
        double _pi = 3.14;
        double _area = _pi * _radius * _radius;
        return _area;
    }
}