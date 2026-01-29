public class NotificationService
{
    public void SendEmail(string email, string subject, string body)
    {
        Console.WriteLine($"NotificationService: Email envoyé à {email}");
    }

    public void SendSMS(string phone, string message)
    {
        Console.WriteLine($"NotificationService: SMS envoyé à {phone}");
    }
}