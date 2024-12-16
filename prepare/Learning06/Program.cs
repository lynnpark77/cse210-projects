using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Square square1 = new Square("Red", 4);
        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("Purple", 4, 6);
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("Blue", 7);
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine ($"The {color} shape has an area of {area}.");
        }

        


    }

}