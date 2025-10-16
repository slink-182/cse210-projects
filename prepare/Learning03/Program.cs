using System;

class Program
{
    public static void Main(string[] args)
    {
        // fraction 1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        // fraction 2
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //fraction 3
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());//grab the basic fraction
        Console.WriteLine(f3.GetDecimalValue());//grab what the decimal output is
    }
}