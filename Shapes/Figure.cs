public abstract class Figure
{
    public double Dim1 { get; set; }
    public double Dim2 { get; set; }

    public Figure(double a, double b)
    {
        Dim1 = a;
        Dim2 = b;
    }

    public abstract double Area();
}

public class Rectangle : Figure
{
    public Rectangle(double a, double b) : base(a, b) { }

    public sealed override double Area()
    {
        Console.WriteLine("Inside Area for Rectangle");
        return Dim1 * Dim2;
    }
}

public class Triangle : Figure
{
    public Triangle(double a, double b) : base(a, b) { }

    public override double Area()
    {
        Console.WriteLine("Inside Area for Triangle");
        return Dim1 * Dim2 / 2;
    }
}

public class RectangleOnWheels : Rectangle
{
    public RectangleOnWheels(double a, double b) : base(a, b)
    {
    }

    /*
    public override double Area()
    {
        return Dim1 * Dim2 * 10;
    }
    */ // COMPILE ERROR because Area method on base class is "sealed"
}