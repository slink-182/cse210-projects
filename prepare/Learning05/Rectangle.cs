
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    //set methods
    public override double GetArea()
    {
        double _area = _length * _width;
        return _area;
    }

}