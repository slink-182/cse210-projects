using System;


public class Fraction
{
    //define top and bottom variables
    private int _top;
    private int _bottom;

    public Fraction()//set default fraction to 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)//first scenario using one provided value
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)//two values are present
    {
        // if (bottom == 0)//account for the denominator being zero
        // {
        //     throw new ArgumentException("Denominator cannot be zero.");//ChatGPT showed me this.
        // }
        _top = top;
        _bottom = bottom;
    }
    // public int GetBottom() => _bottom;
    // public int GetTop() => _top;
    // public void SetTop(int top) => _top = top;
    // public void SetBottom(int bottom)
    // {
        // if (bottom == 0)
        //     throw new ArgumentException("Denominator cannot be zero.");
        // _bottom = bottom;
    // }
    // public string GetFractionString() => $"{_top}/{_bottom}";//Chat showed me this way -- I'll stick with standard format for consistency
    // public double GetDecimalValue() => (double)_top / (double)_bottom;

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}


//I love how trying to use AI to understand C# is making it 10 times more complicated.

