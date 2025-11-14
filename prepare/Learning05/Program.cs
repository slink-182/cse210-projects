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

        Console.WriteLine("color: ");
        string _chosenColor = Console.ReadLine();
        square1.SetColor(_chosenColor);


        //find the area of each object
        double _squareArea = square1.GetArea();
        double _rectangleArea = rectangle1.GetArea();
        double _circleArea = circle1.GetArea();

        //print the area of each object
        Console.WriteLine($"The area of a square: {_squareArea}");
        Console.WriteLine($"The area of a rectangle: {_rectangleArea}");
        Console.WriteLine($"The area of a circle is: {_circleArea}");




    }
}

//notes
//by this point i don't understand the need for the SetColor() method. 
//Why do that through a method when you can ask the user for the color along with all the different sides and 
//radius for each of the shapes and then pass those into the parameters for the objects when they're created.