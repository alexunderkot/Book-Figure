using System;

public abstract class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract double Area2 { get; }
    public abstract double Area();

    public virtual void Print()
    {
        Console.WriteLine($"Figure: {name}");
    }
}

public class Triangle : Figure
{
    private double a, b, c;

    public Triangle(string name, double a, double b, double c) : base(name)
    {
        SetABC(a, b, c);
    }

    public void SetABC(double a, double b, double c)
    {
        if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        else
        {
            throw new ArgumentException("Triangle with that sides doesnt exist!-_-");
        }
    }

    public void GetABC(out double a, out double b, out double c)
    {
        a = this.a;
        b = this.b;
        c = this.c;
    }

    public override double Area2
    {
        get
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    public override double Area()
    {
        return Area2;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Sides: a={a:F2}, b={b:F2}, c={c:F2}");
        Console.WriteLine($"Area: {Area():F2}");
    }
}

public class TriangleColor : Triangle
{
    private string color;

    public TriangleColor(string name, double a, double b, double c, string color)
        : base(name, a, b, c)
    {
        this.color = color;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public override double Area2
    {
        get { return base.Area2; }
    }

    public override double Area()
    {
        return base.Area();
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Color: {color}");
    }
}

public class ProgramF
{
    public static void Main()
    {
        Triangle triangle = new Triangle("Triangle", 3, 4, 5);
        triangle.Print();

        TriangleColor colorTriangle = new TriangleColor("Colored", 6, 8, 10, "Red");
        colorTriangle.Print();

        Figure figure = colorTriangle;
        figure.Print();
    }
}