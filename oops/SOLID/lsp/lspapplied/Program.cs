using lspapplied;

namespace lspapplied;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LSP Applied");
        IColor color = new Green();
        color.GetColor();
        color = new Blue();
        color.GetColor();
    }
}

interface IColor
{
    public void GetColor();
}

public class Green : IColor
{
    public void GetColor()
    {
        System.Console.WriteLine("Green");
    }
}

public class Blue : IColor
{
    public void GetColor()
    {
        System.Console.WriteLine("Blue");
    }
}