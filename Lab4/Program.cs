using System;

interface IDisplayable
{
    void Display();
}

interface IResizable
{
    void Resize(int factor);
}

interface IRotatable
{
    void Rotate(int angle);
}

public class Point : IDisplayable
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Point at ({X}, {Y})");
    }
}

public class Shape : Point, IDisplayable, IResizable, IRotatable
{
    public string Color { get; set; }

    public Shape(int x, int y, string color) : base(x, y)
    {
        Color = color;
    }

    public virtual void Resize(int factor)
    {
        Console.WriteLine($"Resizing shape by factor {factor}");
    }

    public virtual void Rotate(int angle)
    {
        Console.WriteLine($"Rotating shape by angle {angle} degrees");
    }
}

public class Circle : Shape, IDisplayable, IResizable
{
    public int Radius { get; set; }

    public Circle(int x, int y, string color, int radius) : base(x, y, color)
    {
        Radius = radius;
    }

    public override void Display()
    {
        Console.WriteLine($"Circle at ({X}, {Y}), Radius: {Radius}, Color: {Color}");
    }

    public override void Resize(int factor)
    {
        Radius *= factor;
        Console.WriteLine($"Resizing circle to radius {Radius}");
    }
}

public class Ellipse : Shape, IDisplayable, IResizable
{
    public int MajorAxis { get; set; }
    public int MinorAxis { get; set; }

    public Ellipse(int x, int y, string color, int majorAxis, int minorAxis) : base(x, y, color)
    {
        MajorAxis = majorAxis;
        MinorAxis = minorAxis;
    }

    public override void Display()
    {
        Console.WriteLine($"Ellipse at ({X}, {Y}), Major Axis: {MajorAxis}, Minor Axis: {MinorAxis}, Color: {Color}");
    }

    public void Resize(int factor)
    {
        MajorAxis *= factor;
        MinorAxis *= factor;
        Console.WriteLine($"Resizing ellipse to Major Axis: {MajorAxis}, Minor Axis: {MinorAxis}");
    }
}

public class Ring : Circle, IDisplayable, IResizable, IRotatable
{
    public int InnerRadius { get; set; }

    public Ring(int x, int y, string color, int radius, int innerRadius) : base(x, y, color, radius)
    {
        InnerRadius = innerRadius;
    }

    public override void Display()
    {
        Console.WriteLine($"Ring at ({X}, {Y}), Radius: {Radius}, Inner Radius: {InnerRadius}, Color: {Color}");
    }
    public override void Resize(int factor)
    {
        base.Resize(factor);
        InnerRadius *= factor;
        Console.WriteLine($"Resizing ring to radius {Radius} and inner radius {InnerRadius}");
    }



} 
class Program {
        static void Main()
        {
   
            Circle circle = new Circle(10, 20, "Red", 5);
            circle.Display();
            circle.Resize(2);

            Ellipse ellipse = new Ellipse(30, 40, "Blue", 8, 5);
            ellipse.Display();
            ellipse.Resize(3);

            Ring ring = new Ring(50, 60, "Green", 10, 7);
            ring.Display();
            ring.Resize(1);
            ring.Rotate(180);
        }
    }