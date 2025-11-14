public class Square : Shape
{
    //set attributes
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;


    }
    //set methods
    public override double GetArea()
    {
        double _area = _side * _side;
        return _area;
    }

    


}