using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape
{
    public void print()
    {
        Console.WriteLine("shape print()");
    }

    public abstract double CalculateArea();
}

public class Circle : Shape
{
    // public double radius;
    public double Radius { get; set; }

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }  
    public double Height { get; set; }

    public Rectangle(double x, double y)
    {
        if(x < 0) x = 0;
        if(y < 0) y = 0;

        Width = x;
        Height = y;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Test07
{
    public static void Main07(string[] args)
    {
        Circle circle = new Circle(3.3);
        Console.WriteLine(circle.CalculateArea());

        Rectangle rect = new Rectangle(2.0, 5.0);
        Console.WriteLine(rect.CalculateArea());
    }
}

