namespace dipapplied;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DIP Applied");
    }
}

public interface IEmailSender
{
    void SendEmail(string email, string subject, string body);
}

public class EmailService : IEmailSender
{
    public void SendEmail(string email, string subject, string body)
    {
        // Email sending logic using a specific library
    }
}

public class CustomerService
{
    private readonly IEmailSender _emailSender; // Dependency injection through constructor

    public CustomerService(IEmailSender emailSender) // Constructor injection
    {
        _emailSender = emailSender;
    }

    public void AddCustomer(string name, string email)
    {
        // Add customer logic
        _emailSender.SendEmail(email, "Welcome!", "Welcome to our store!"); // Use the interface

    }
}