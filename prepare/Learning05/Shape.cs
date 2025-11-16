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

    // public void SetColor(string color)
    // {
    //     _color = color;
    // }
    public abstract double GetArea();
    
}

// notes
//I don't understand why we have a SetColor() method when it isn't used in program.cs, or anywhere else in this project.
