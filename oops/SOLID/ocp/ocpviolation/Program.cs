namespace ocpviolation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OCP violation");
    }

}

// Bad design violating OCP
class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circle : Shape
{
    int radius = 2;
    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}