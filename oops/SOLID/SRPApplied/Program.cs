namespace SRPApplied;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TestClass tc = new TestClass();
    }
}

public class CustomerService
{
    public void AddCustomer(string name, string email)
    {
        // Add customer logic (can call a separate validation service)
    }
}

public class EmailService
{
    public bool ValidateEmail(string email)
    {
        // Email validation logic
    }

    public void SendWelcomeEmail(string email)
    {
        // Email sending logic
    }
}

