using System;

// An abstract class cannot be instantiated directly and serves as a base.
public abstract class Shape
{
    public string Name { get; set; }

    // A non-abstract method with implementation.
    public void DisplayShapeInfo()
    {
        Console.WriteLine($"This is a {Name}.");
    }

    // Abstract methods must be implemented by concrete derived classes.
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

// Derived concrete class: Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string name, double radius)
    {
        Name = name;
        Radius = radius;
    }

    // Implement abstract methods for Circle.
    public override double CalculateArea() => Math.PI * Radius * Radius;
    public override double CalculatePerimeter() => 2 * Math.PI * Radius;
}

// Derived concrete class: Rectangle
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(string name, double length, double width)
    {
        Name = name;
        Length = length;
        Width = width;
    }

    // Implement abstract methods for Rectangle.
    public override double CalculateArea() => Length * Width;
    public override double CalculatePerimeter() => 2 * (Length + Width);
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Abstract Classes and Methods in C# (Concise)\n");

        Circle circle = new Circle("My Circle", 5.0);
        Rectangle rectangle = new Rectangle("My Rectangle", 4.0, 6.0);

        circle.DisplayShapeInfo();
        Console.WriteLine($"Area: {circle.CalculateArea():F2}, Perimeter: {circle.CalculatePerimeter():F2}\n");

        rectangle.DisplayShapeInfo();
        Console.WriteLine($"Area: {rectangle.CalculateArea():F2}, Perimeter: {rectangle.CalculatePerimeter():F2}\n");

        Console.WriteLine("--- Polymorphism with Abstract Class ---");
        Shape shape1 = new Circle("Another Circle", 7.0);
        Shape shape2 = new Rectangle("Another Rectangle", 3.0, 8.0);

        Console.WriteLine($"Area of {shape1.Name}: {shape1.CalculateArea():F2}, Perimeter: {shape1.CalculatePerimeter():F2}\n");
        Console.WriteLine($"Area of {shape2.Name}: {shape2.CalculateArea():F2}, Perimeter: {shape2.CalculatePerimeter():F2}");
    }
}
