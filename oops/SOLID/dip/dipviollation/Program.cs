namespace dipviollation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DIP violation");
    }
}

public class EmailService
{
    public void SendWelcomeEmail(string email) // Sends email directly
    {
        // Email sending logic using a specific library
    }
}

public class CustomerService
{
    public void AddCustomer(string name, string email)
    {
        // Add customer logic
        new EmailService().SendWelcomeEmail(email); // Directly depends on EmailService class
    }
}

