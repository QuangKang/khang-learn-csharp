using System;

Shape myCircle = new Circle(5.5);
Shape myRectangle = new Rectangle(3, 4);

myCircle.PrintInfo();
myRectangle.PrintInfo();

public interface IShape
{
    double calculateArea();
}

public abstract class Shape : IShape
{
    public string Name { get; set; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double calculateArea();

    public void PrintInfo()
    {
        Console.WriteLine($"[{Name}] Area = {Math.Round(calculateArea(), 2)}");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double calculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height) : base("Rectangle")
    {
        Width = width;
        Height = height;
    }

    public override double calculateArea()
    {
        return Width * Height;
    }
}