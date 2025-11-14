using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        //create the objects
        //square
        Square square1 = new Square(3, "orange");
        //Rectangle
        Rectangle rectangle1 = new Rectangle(2, 4, "green");
        //circle
        Circle circle1 = new Circle(3, "purple");

        double _squareArea = square1.GetArea();
        double _rectangleArea = rectangle1.GetArea();
        double _circleArea = circle1.GetArea();

        Console.WriteLine($"The area of a square: {_squareArea}");
        Console.WriteLine($"The area of a rectangle: {_rectangleArea}");
        Console.WriteLine($"The area of a circle is: {_circleArea}");
        



    }
}