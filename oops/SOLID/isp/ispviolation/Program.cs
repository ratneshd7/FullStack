namespace ispviolation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ISP Violation");
    }
}
public interface IPaymentProcessor
{
    void ProcessCreditCardPayment(string cardNumber, string expiryDate, double amount);
    void ProcessPayPalPayment(string email, string password, double amount);
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void ProcessCreditCardPayment(string cardNumber, string expiryDate, double amount)
    {
        // Process credit card payment logic
    }

    public void ProcessPayPalPayment(string email, string password, double amount)
    {
        throw new NotImplementedException("Not supported"); // Not relevant for credit cards
    }
}

public class OnlineStore
{
    public void MakePayment(IPaymentProcessor processor, double amount)
    {
        // Use the processor to make the payment (might call unused methods)
    }
}
