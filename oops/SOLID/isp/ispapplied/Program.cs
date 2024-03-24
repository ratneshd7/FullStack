namespace ispapplied;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ISP Applied");
    }
}

public interface ICreditCardPaymentProcessor
{
    void ProcessCreditCardPayment(string cardNumber, string expiryDate, double amount);
}

public interface IPayPalPaymentProcessor
{
    void ProcessPayPalPayment(string email, string password, double amount);
}

public class CreditCardPaymentProcessor : ICreditCardPaymentProcessor
{
    public void ProcessCreditCardPayment(string cardNumber, string expiryDate, double amount)
    {
        // Process credit card payment logic
    }
}

public class OnlineStore
{
    public void MakePayment(ICreditCardPaymentProcessor processor, double amount) // Use specific interface
    {
        processor.ProcessCreditCardPayment(..., amount); // Call relevant method
    }
}

