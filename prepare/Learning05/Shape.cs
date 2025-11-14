//parent class/ super class
public abstract class Shape
{

    //attributes
    private string _color;

    public Shape(string color)
    {
        _color = color;

    }

    //set methods
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        //asdf
        Console.Write("What color is your shape? ");
        string _color = Console.ReadLine();
        

    }

    public abstract double GetArea();

}