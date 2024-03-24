namespace ocpapplied;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OCP  Applied");
    }
}

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}

public class Square : Shape
{
    private readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public override double Area()
    {
        return Math.Pow(_side, 2);
    }
}

