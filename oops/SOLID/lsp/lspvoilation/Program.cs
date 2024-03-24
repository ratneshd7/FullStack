namespace lspvoilation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("lsp violation");
        // violate LSP because color of green object is blue
        Green green = new Blue();
        green.GetColor();//output: Blue 
    }
}

class Green
{
    public virtual void GetColor()
    {
        System.Console.WriteLine("Green");
    }
}

class Blue : Green
{
    public override void GetColor()
    {
        System.Console.WriteLine("Blue");
    }
}
