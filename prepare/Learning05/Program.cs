using System;
using System.Drawing;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        Square squareObject = new Square(2, "silver");
        shapeList.Add(squareObject);
        Rectangle rectangleObject = new Rectangle(3, 2, "crimson");
        shapeList.Add(rectangleObject);
        Circle circleObject = new Circle(3,"teal");
        shapeList.Add(circleObject);

        foreach (Shape singleObject in shapeList)
        {
            string color = singleObject.GetColor();
            double area = singleObject.GetArea();
            Console.WriteLine($"the {color} shapes area is: {area}");
        }
    }
}


