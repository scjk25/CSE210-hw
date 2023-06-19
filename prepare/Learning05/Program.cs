using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();

       Square square = new Square("Yellow", 10);
       shapes.Add(square);

       Rectangle rectangle = new Rectangle("Purple", 5, 4);
       shapes.Add(rectangle);

       Circle circle = new Circle("White", 8);
       shapes.Add(circle);

       foreach(Shape i in shapes)
       {
            string color = i.GetColor();
            double area = i.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
       }
    }
}