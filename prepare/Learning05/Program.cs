using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
       

        Circle circle = new Circle("Red", 5);
        

        Rectangle rectangle = new Rectangle("Red", 5, 7);
       

        square.SetColor("Blue");
        
        rectangle.SetColor("Orange");
       
        circle.SetColor("Gold");
        


        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);

        foreach (Shape shapes1 in shapes)
        {
            string color = shapes1.GetColor();
            double area = shapes1.GetArea();
            Console.WriteLine($"Shape Color: {color}, Area: {area}");
        }
    }
}